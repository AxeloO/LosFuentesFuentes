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

                Inventario _en = new Inventario();
                InventarioBL _inventarioBl = new InventarioBL();
                int intVerificador = 0;

                string strNombreProveedor = txtNombreProveedor.Text.ToString().Trim();
                string strFactura = txtNoFactura.Text.ToString().Trim();
                string strFechaAdquisicion = txtFechaAdquisicion.Text.ToString().Trim();
                string strProductoAdquirido = txtProductoAdquirido.Text.ToString().Trim();
                string strCantidad = txtCantidad.Text.ToString().Trim();
                string strTotalAPagar = txtMontoPagar.Text.ToString().Trim();
                string strStatus = txtStatus.Text.ToString().Trim();
                             


                if (txtNombreProveedor.Text ==("") || txtNoFactura.Text ==("") || txtFechaAdquisicion.Text ==("") || txtProductoAdquirido.Text == ("") || txtCantidad.Text ==("") || txtMontoPagar.Text == ("") || txtStatus.Text == ("") )
                {
                    MessageBox.Show("Parece que olvidaste llenar todos los campos", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    _enCuentas.FcNombreProveedor = txtNombreProveedor.Text;
                    _enCuentas.FiNoFactura = int.Parse(txtNoFactura.Text);
                    _enCuentas.FDtFechaAdquisicion = txtFechaAdquisicion.Text;
                    _enCuentas.FcProductoAdquirido = txtProductoAdquirido.Text;
                    _enCuentas.FdTotalAPagar = int.Parse(txtMontoPagar.Text);
                    _enCuentas.FdCantidad = decimal.Parse(txtCantidad.Text);
                    _enCuentas.FcStatus = txtStatus.Text;                   

                    

                    foreach (var productoInventario in _inventarioBl.MostrarInventario())
                    {
                        _en.IdProducto = productoInventario.IdProducto;
                        _en.NombreProducto = productoInventario.NombreProducto;
                        _en.GrupoPertenenciente = productoInventario.GrupoPertenenciente;
                        _en.Cantidad = productoInventario.Cantidad;
                        _en.Presentacion = productoInventario.Presentacion;
                        _en.CostoUnitario = productoInventario.CostoUnitario;
                        _en.PrecioContado = productoInventario.PrecioContado;
                        _en.PrecioACredito = productoInventario.PrecioACredito;

                        if (_en.NombreProducto.Equals(_enCuentas.FcProductoAdquirido))
                        {
                            _en.Cantidad = _en.Cantidad + int.Parse(_enCuentas.FdCantidad.ToString());
                            _inventarioBl.ModificarProducto(_en);
                            int Resultado = _cuentasBL.AgregarCuentasPorPagar(_enCuentas);
                            MessageBox.Show("¡Se realizó el Registro Correctamente!");
                            intVerificador = 1;

                        }



                    }
                    if (intVerificador != 1)
                    {
                        MessageBox.Show("No se Encontro el Producto, Favor de verificar");

                    }

                    
                }
            }

            catch (Exception ex)
            {
                throw ex;
                MessageBox.Show("Hubo un error al agregar el registro", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string strIdCuentas = txtID.Text.ToString().Trim();
                if (strIdCuentas != "" && txtNombreProveedor.Text != "")
                {
                    DialogResult r = MessageBox.Show("¿Estas seguro de eliminar este registro?", "¡Alerta!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (r == DialogResult.OK)
                    {
                        long longIdCuentas = long.Parse(strIdCuentas);

                        _enCuentas.FiIdProveedor = longIdCuentas;

                        _cuentasBL.EliminarCuentas(_enCuentas);
                        dGCuentasPagar.Refresh();
                        dGCuentasPagar.DataSource = _cuentasBL.MostrarCuentasPorPagar();
                        Limpiar();
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

        public void Limpiar()
        {
            txtID.Text = string.Empty;
            txtNoFactura.Text = string.Empty;
            txtNombreProveedor.Text = string.Empty;
            txtProductoAdquirido.Text = string.Empty;
            txtFechaAdquisicion.Text = string.Empty;
            txtCantidad.Text = string.Empty;
            txtMontoPagar.Text = string.Empty;
            txtStatus.Text =string.Empty;
            txtNombreProveedor.Focus();
        }

        private void dGCuentasPagar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dGCuentasPagar.Rows[e.RowIndex].Cells["FiIdProveedor"].Value.ToString();
            txtNombreProveedor.Text = dGCuentasPagar.Rows[e.RowIndex].Cells["FcNombreProveedor"].Value.ToString();
            txtNoFactura.Text = dGCuentasPagar.Rows[e.RowIndex].Cells["FiNoFactura"].Value.ToString();
            txtFechaAdquisicion.Text = dGCuentasPagar.Rows[e.RowIndex].Cells["FDtFechaAdquisicion"].Value.ToString();
            txtProductoAdquirido.Text = dGCuentasPagar.Rows[e.RowIndex].Cells["FcProductoAdquirido"].Value.ToString();
            txtCantidad.Text = dGCuentasPagar.Rows[e.RowIndex].Cells["FdCantidad"].Value.ToString();
            txtMontoPagar.Text = dGCuentasPagar.Rows[e.RowIndex].Cells["FdTotalAPagar"].Value.ToString();
            txtStatus.Text = dGCuentasPagar.Rows[e.RowIndex].Cells["FcStatus"].Value.ToString();

        }

        private void bModificar_Click(object sender, EventArgs e)
        {

            string strIdCuentasPagar = txtID.Text.ToString().Trim();
            string strNombreProveedor = txtNombreProveedor.Text.ToString().Trim();
            string strNoFactura = txtNoFactura.Text.ToString().Trim();
            string strFechaAdquisicion = txtFechaAdquisicion.Text.ToString().Trim();
            string strProductoAdquirido = txtProductoAdquirido.Text.ToString().Trim();
            string strCantidad = txtCantidad.Text.ToString().Trim();
            string strMontoPagar = txtMontoPagar.Text.ToString().Trim();
            string strStatus = txtStatus.Text.ToString().Trim();

            if (strIdCuentasPagar !="" && strNombreProveedor !="")
            {
           _enCuentas.FiIdProveedor = long.Parse(txtID.Text);
           _enCuentas.FcNombreProveedor = txtNombreProveedor.Text;
           _enCuentas.FiNoFactura = int.Parse(txtNoFactura.Text);
           _enCuentas.FDtFechaAdquisicion = txtFechaAdquisicion.Text;
           _enCuentas.FcProductoAdquirido = txtProductoAdquirido.Text;
           _enCuentas.FdCantidad = decimal.Parse(txtCantidad.Text);
           _enCuentas.FdTotalAPagar = decimal.Parse(txtCantidad.Text);
           _enCuentas.FcStatus = txtStatus.Text;
         

           if (_cuentasBL.ModificarCuentas(_enCuentas) > 0)
               {
                   MessageBox.Show("El registro se modificó correctamente", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                   dGCuentasPagar.Refresh();
                   dGCuentasPagar.DataSource = _cuentasBL.MostrarCuentasPorPagar();
               Limpiar();
               }

               else
               {
                   MessageBox.Show("Ocurrio un problema, no se pudo modificar", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }

           }
           else
           {
               MessageBox.Show("Seleccione un registro", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
           }
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            if (!(txtBusqueda.Text == ""))
            {
                _enCuentas.FcNombreProveedor = txtBusqueda.Text;
                dGCuentasPagar.DataSource = _cuentasBL.MostrarCuentasPorNombre(_enCuentas);
            }
        }

     
    }
}
