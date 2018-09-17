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
    public partial class FCuentasPagar : Form
    {
        EnCuentasPorPagar _enCuentas = new EnCuentasPorPagar();
        CuentasPorPagarBL _cuentasBL = new CuentasPorPagarBL();

        public FCuentasPagar()
        {
            InitializeComponent();
        }

        private void FCuentasPagar_Load(object sender, EventArgs e)
        {

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);

        private void FCuentasCobrar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void bActualizar_Click(object sender, EventArgs e)
        {
            dGCuentasPagar.DataSource = _cuentasBL.MostrarCuentasPorPagar();
        }

        private void bRegresar_Click(object sender, EventArgs e)
        {
            FMenuClientes _fPrincipal = new FMenuClientes();
            _fPrincipal.Show();
            this.Close();
        }

        private void FCuentasPagar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            try
            {//Trim sirve para borrar espacios si es que existen 

       
                string strNombreProveedor = txtNombreProveedor.Text.ToString().Trim();
                string strFactura = txtNoFactura.Text.ToString().Trim();
                string strFechaAdquisicion = txtFechaAdquisicion.Text.ToString().Trim();
                string strProductoAdquirido = txtProductoAdquirido.Text.ToString().Trim();
                string strTotalAPagar = txtMontoPagar.Text.ToString().Trim();
              


                if (txtNombreProveedor.Text ==("") || txtNoFactura.Text ==("") || txtFechaAdquisicion.Text ==("") || txtProductoAdquirido.Text == ("") || txtMontoPagar.Text == (""))
                {
                    MessageBox.Show("Parece que olvidaste llenar todos los campos", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    _enCuentas.FcNombreProveedor = txtNombreProveedor.Text;
                    _enCuentas.FiNoFactura = int.Parse(txtNoFactura.Text);
                    _enCuentas.FDtFechaAdquisicion = txtFechaAdquisicion.Text;
                    _enCuentas.FcProductoAdquirido = txtProductoAdquirido.Text;
                    _enCuentas.FdTotalAPagar = int.Parse(txtMontoPagar.Text);
                   

                    int Resultado = _cuentasBL.AgregarCuentasPorPagar(_enCuentas);

                    if (Resultado == 1)
                    {
                        MessageBox.Show("Se Agrego El Nuevo Registro Correctamente", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }

                }
            }

            catch (Exception)
            {

                MessageBox.Show("Hubo un error al Agregar el Registro", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string strIdCuentas = txtID.Text.ToString().Trim();
                if (strIdCuentas != "" && txtNombreProveedor.Text != "")
                {
                    DialogResult r = MessageBox.Show("Estas seguro de eliminar este registro?", "Alerta!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (r == DialogResult.OK)
                    {
                        long longIdCuentas = long.Parse(strIdCuentas);

                        _enCuentas.FiIdProveedor = longIdCuentas;

                        _cuentasBL.EliminarCuentas(_enCuentas);
                        dGCuentasPagar.Refresh();
                        dGCuentasPagar.DataSource = _cuentasBL.MostrarCuentasPorPagar();
                    }
                    if (r == DialogResult.Cancel)
                    {

                    }

                }

                if (_cuentasBL.EliminarCuentas(_enCuentas) > 0)//if (_inventarioBl.ModificarProducto(_en) > 0)
                {

                }
            }

            catch (Exception)
            {

                throw;
            }

        }
    }
}
