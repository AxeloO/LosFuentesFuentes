using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using BL;
using EN;


namespace WFFuentes
{
    public partial class FDevoluciones : Form 
    {
        DevolucionesBL _bldevolucion = new DevolucionesBL();
        EnDevolucion _enDevolucion = new EnDevolucion();

        public FDevoluciones()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);

        private void FDevoluciones_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void bRegresar_Click(object sender, EventArgs e)
        {
            FMenuEmpleado _fPrincipal = new FMenuEmpleado();
            _fPrincipal.Show();
            this.Close();
        }

        private void FDevoluciones_Load(object sender, EventArgs e)
        {

        }

        private void bLimpiar_Click(object sender, EventArgs e)
        {
            txtFolioNota.Text = string.Empty;
            txtNombreProducto.Text = string.Empty;
            txtCantidad.Text = string.Empty;
            txtCausaDevolucion.Text = string.Empty;          
        }

        private void bConsulta_Click(object sender, EventArgs e)
        {
            dGDevoluciones.DataSource = _bldevolucion.ListaDevoluciones();
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            try
            {//Trim sirve para borrar espacios si es que existen 


                String strfolioNota = txtFolioNota.Text.ToString().Trim();
                String strNombreProducto = txtNombreProducto.Text.ToString().Trim();
                String strCantidad = txtCantidad.Text.ToString().Trim();
                String strCausaD = txtCausaDevolucion.Text.ToString().Trim();


                if (strfolioNota.Equals("") || strNombreProducto.Equals("")  || txtCantidad.Equals("") || strCausaD.Equals(""))
                {
                    MessageBox.Show("Parece que olvidaste llenar todos los campos", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    _enDevolucion.fiFolioVenta = int.Parse(txtFolioNota.Text);
                    _enDevolucion.fcNombreProductoDevolucion = txtNombreProducto.Text;
                    _enDevolucion.fiCantidadDevolucion = int.Parse(txtCantidad.Text);
                    _enDevolucion.fcCausaDevolucion = txtCausaDevolucion.Text;
                   

                    int Resultado = _bldevolucion.AgregarDevolucion(_enDevolucion);

                    if (Resultado == 1)
                    {
                        MessageBox.Show("Se Agrego El Nuevo Producto Correctamente", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }

                }
            }

            catch (Exception)
            {

                MessageBox.Show("Hubo un error al Agregar el Producto", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }
    }
}
