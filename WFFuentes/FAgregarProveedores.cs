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
using EN;
using BL;

namespace WFFuentes
{
    public partial class FAgregarProveedores : Form
    {

        EnProveedores _enProveedores = new EnProveedores();
        ProveedoresBL proveedoresBL = new ProveedoresBL();

        public FAgregarProveedores()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);

        private void FAgregarProveedores_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void bRegresar_Click(object sender, EventArgs e)
        {
            FMenuClientes _fPrincipal = new FMenuClientes();
            _fPrincipal.Show();
            this.Close();
        }

        private void bLimpiar_Click(object sender, EventArgs e)
        {
            txtNombreCompleto.Text = string.Empty;
            txtDomicilio.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtRFC.Text = string.Empty;
            txtCuentaBancaria.Text = string.Empty;
            txtProductoSurtir.Text = string.Empty;
            txtLimiteCredito.Text = string.Empty;
            
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
           
        }

        private void bGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {//Trim sirve para borrar espacios si es que existen hOLA ZURY


                string strNombreProveedor = txtNombreCompleto.Text.ToString().Trim();
                string strDomicilio = txtDomicilio.Text.ToString().Trim();
                string strTelefono = txtTelefono.Text.ToString().Trim();
                string strRFC = txtRFC.Text.ToString().Trim();
                string strCuentaBancaria = txtCuentaBancaria.Text.ToString().Trim();
                string strProductoSurtir = txtProductoSurtir.Text.ToString().Trim();
                string strLimiteCredito = txtLimiteCredito.Text.ToString().Trim();


                if (strNombreProveedor.Equals("") || strDomicilio.Equals("") || strTelefono.Equals("") || strRFC.Equals("") || strCuentaBancaria.Equals("") || strProductoSurtir.Equals("") || strLimiteCredito.Equals(""))
                {
                    MessageBox.Show("Parece que olvidaste llenar todos los campos", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    _enProveedores.FcNombreProveedor = txtNombreCompleto.Text;
                    _enProveedores.FcDomicilio = txtDomicilio.Text;
                    _enProveedores.FiTelefono = int.Parse(txtTelefono.Text);
                    _enProveedores.FcRFC = txtRFC.Text;
                    _enProveedores.FcCuentaBancaria = txtCuentaBancaria.Text;
                    _enProveedores.FcProductosSurtidos = txtProductoSurtir.Text;
                    _enProveedores.FdLimiteCredito = decimal.Parse(txtLimiteCredito.Text);


                    int Resultado = proveedoresBL.AgregarProveedor(_enProveedores);

                    if (Resultado == 1)
                    {
                        MessageBox.Show("Se Agrego El Nuevo Proveedor Correctamente", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }

                }
            }

            catch (Exception)
            {

                MessageBox.Show("Hubo un error al Agregar el Proveedor", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void bConsulta_Click(object sender, EventArgs e)
        {


            dGProveedores.DataSource = proveedoresBL.MostrarProveedor();
        }
    }
}
