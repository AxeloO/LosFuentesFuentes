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

        private void Limpiar()
        {
            txtID.Text = string.Empty;
            txtNombreCompleto.Text = string.Empty;
            txtDomicilio.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtRFC.Text = string.Empty;
            txtCuentaBancaria.Text = string.Empty;
            txtProductoSurtir.Text = string.Empty;
            txtLimiteCredito.Text = string.Empty;
            txtNombreCompleto.Focus();
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
                    _enProveedores.FcDireccion = txtDomicilio.Text;
                    _enProveedores.FiTelefono = txtTelefono.Text;
                    _enProveedores.FcRFC = txtRFC.Text;
                    _enProveedores.FcCuentaBancaria = txtCuentaBancaria.Text;
                    _enProveedores.FcProductosSurtidos = txtProductoSurtir.Text;
                    _enProveedores.FdLimiteCredito = decimal.Parse(txtLimiteCredito.Text);
                    int Resultado = proveedoresBL.AgregarProveedor(_enProveedores);
                    if (Resultado == 1)
                    {
                        MessageBox.Show("Se agrego el nuevo proveedor correctamente", "Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Limpiar();
                    
                    }
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Hubo un error al agregar el proveedor", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void bConsulta_Click(object sender, EventArgs e)
        {
            dGProveedores.DataSource = proveedoresBL.MostrarProveedor();
        }

        private void bBusqueda_Click(object sender, EventArgs e)
        {
            if (!(txtBusqueda.Text == ""))
            {
                _enProveedores.FcNombreProveedor = txtBusqueda.Text;
                dGProveedores.DataSource = proveedoresBL.MostrarProveedorPorNombre(_enProveedores);
            }
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string strIdProveedor = txtID.Text.ToString().Trim();
                if (strIdProveedor != "" && txtNombreCompleto.Text != "")
                {
                    DialogResult r = MessageBox.Show("Estas seguro de eliminar este registro?", "Alerta!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (r == DialogResult.OK)
                    {
                        long longIdProveedor = long.Parse(strIdProveedor);

                        _enProveedores.FiIdProveedor = longIdProveedor;

                        proveedoresBL.EliminarProveedor(_enProveedores);
                        dGProveedores.Refresh();
                        dGProveedores.DataSource = proveedoresBL.MostrarProveedor();
                        Limpiar();
                    }
                    if (r == DialogResult.Cancel)
                    {

                    }

                }

                if (proveedoresBL.EliminarProveedor(_enProveedores) > 0)//if (_inventarioBl.ModificarProducto(_en) > 0)
                {

                }
            }

            catch (Exception)
            {

                throw;
            }

        }

        private void dGProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dGProveedores.Rows[e.RowIndex].Cells["FiIdProveedor"].Value.ToString();
            txtNombreCompleto.Text = dGProveedores.Rows[e.RowIndex].Cells["FcNombreProveedor"].Value.ToString();
            txtDomicilio.Text = dGProveedores.Rows[e.RowIndex].Cells["FcDireccion"].Value.ToString();
            txtTelefono.Text = dGProveedores.Rows[e.RowIndex].Cells["FiTelefono"].Value.ToString();
            txtRFC.Text = dGProveedores.Rows[e.RowIndex].Cells["FcRFC"].Value.ToString();
            txtCuentaBancaria.Text = dGProveedores.Rows[e.RowIndex].Cells["FcCuentaBancaria"].Value.ToString();
            txtProductoSurtir.Text = dGProveedores.Rows[e.RowIndex].Cells["FcProductosSurtidos"].Value.ToString();
            txtLimiteCredito.Text = dGProveedores.Rows[e.RowIndex].Cells["FdLimiteCredito"].Value.ToString();
           
        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            string strIdProveedor = txtID.Text.ToString().Trim();
            string strNombreProveedor = txtNombreCompleto.Text.ToString().Trim();
            string strDomicilio = txtDomicilio.Text.ToString().Trim();
            string strTelefono = txtTelefono.Text.ToString().Trim();
            string strRFC = txtRFC.Text.ToString().Trim();
            string strCuentaBancaria = txtCuentaBancaria.Text.ToString().Trim();
            string strProductoSurtir = txtProductoSurtir.Text.ToString().Trim();
            string strLimiteCredito = txtLimiteCredito.Text.ToString().Trim();

            if (strIdProveedor !="" && strNombreProveedor !="")
                {
                _enProveedores.FiIdProveedor = long.Parse(txtID.Text);
                _enProveedores.FcNombreProveedor = txtNombreCompleto.Text;
                _enProveedores.FcDireccion = txtDomicilio.Text;
                _enProveedores.FiTelefono = txtTelefono.Text;
                _enProveedores.FcRFC = txtRFC.Text;
                _enProveedores.FcCuentaBancaria = txtCuentaBancaria.Text;
                _enProveedores.FcProductosSurtidos = txtProductoSurtir.Text;
                _enProveedores.FdLimiteCredito = decimal.Parse(txtLimiteCredito.Text);

                if (proveedoresBL.ModificarProveedor(_enProveedores) > 0)
                    {
                        MessageBox.Show("Se modificó correctamente", "Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        dGProveedores.Refresh();
                        dGProveedores.DataSource = proveedoresBL.MostrarProveedor();
                    Limpiar();
                    }

                    else
                    {
                        MessageBox.Show("Ocurrio un problema, no se pudo modificar", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Seleccione un Registro", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }

        private void bLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
