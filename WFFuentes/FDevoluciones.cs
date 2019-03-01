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

        private void Limpiar()
        {
            txtID.Text = string.Empty;
            txtFolioNota.Text = string.Empty;
            txtNombreProducto.Text = string.Empty;
            txtCantidad.Text = string.Empty;
            txtCausaDevolucion.Text = string.Empty;
            txtFechaDevolucion.Text = string.Empty;
            txtNombreCliente.Text = string.Empty;
            txtNombreProducto.Focus();
        }

        private void bLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();      
        }

        private void bConsulta_Click(object sender, EventArgs e)
        {
            dGDevoluciones.DataSource = _bldevolucion.ListaDevoluciones();
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            try
            {//Trim sirve para borrar espacios si es que existen 

                Inventario _en = new Inventario();
                InventarioBL _inventarioBl = new InventarioBL();
                int intVerificador = 0;

                string strfolioNota = txtFolioNota.Text.ToString().Trim();
                string strNombreProducto = txtNombreProducto.Text.ToString().Trim();
                string strCantidad = txtCantidad.Text.ToString().Trim();
                string strCausaD = txtCausaDevolucion.Text.ToString().Trim();
                string strNombreDelCliente = txtNombreCliente.Text.ToString().Trim();
                string strFechaDevolucion = txtFechaDevolucion.Text.ToString().Trim(); //Aqui agregue/cambie.. SE supone que aqui agrego manualmente no.!?
                

                if (strfolioNota.Equals("") || strNombreProducto.Equals("")  || txtCantidad.Equals("") || strCausaD.Equals("") || strNombreDelCliente.Equals("") || strFechaDevolucion.Equals("") )
                {
                    MessageBox.Show("Parece que olvidaste llenar todos los campos", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    _enDevolucion.fiFolioVenta = int.Parse(txtFolioNota.Text);
                    _enDevolucion.fcNombreProductoDevolucion = txtNombreProducto.Text;
                    _enDevolucion.fiCantidadDevolucion = int.Parse(txtCantidad.Text);
                    _enDevolucion.fcCausaDevolucion = txtCausaDevolucion.Text;
                    _enDevolucion.fcFechaDevolucion = txtFechaDevolucion.Text;
                    _enDevolucion.fcNombreDelCliente = txtNombreCliente.Text;


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

                        if (_en.NombreProducto.Equals(_enDevolucion.fcNombreProductoDevolucion))
                        {
                            _en.Cantidad = _en.Cantidad + _enDevolucion.fiCantidadDevolucion;
                            _inventarioBl.ModificarProducto(_en);
                            int Resultado = _bldevolucion.AgregarDevolucion(_enDevolucion);

                            MessageBox.Show("¡Se realizó la devolución correctamente!", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            intVerificador = 1;
                            Limpiar();

                        }

                    }
                    if (intVerificador != 1)
                    {
                        MessageBox.Show("No se encontro el producto. Favor de verificar", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Limpiar();

                    }
            }

            }

            catch (Exception)
            {

                MessageBox.Show("Hubo un error al realizar la devolución. Favor de validar", "¡Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

        private void dGDevoluciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dGDevoluciones.Rows[e.RowIndex].Cells["fiIdDevolucion"].Value.ToString();
            txtFolioNota.Text = dGDevoluciones.Rows[e.RowIndex].Cells["fiFolioVenta"].Value.ToString();
            txtFechaDevolucion.Text = dGDevoluciones.Rows[e.RowIndex].Cells["fcFechaDevolucion"].Value.ToString();
            txtNombreCliente.Text = dGDevoluciones.Rows[e.RowIndex].Cells["fcNombreDelCliente"].Value.ToString();
            txtNombreProducto.Text = dGDevoluciones .Rows[e.RowIndex].Cells["fcNombreProductoDevolucion"].Value.ToString();
            txtCantidad.Text = dGDevoluciones.Rows[e.RowIndex].Cells["fiCantidadDevolucion"].Value.ToString();
            txtCausaDevolucion.Text = dGDevoluciones.Rows[e.RowIndex].Cells["fcCausaDevolucion"].Value.ToString();
            
        }

        private void bImprimir_Click(object sender, EventArgs e)
        {
            printDocument1.PrinterSettings.PrinterName = "nombreimpresora";
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dGDevoluciones.Width, this.dGDevoluciones.Height);
            dGDevoluciones.DrawToBitmap(bm, new Rectangle(0, 0, this.dGDevoluciones.Width, this.dGDevoluciones.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void btVistaPrevia_Click(object sender, EventArgs e)
        {

            try
            {
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al imprimir. Favor de salir e ingresar nuevamente a la opción" ,"¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }


    }
}
