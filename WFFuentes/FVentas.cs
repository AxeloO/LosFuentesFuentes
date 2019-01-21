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
    public partial class FVentas : Form
    {
        Bitmap bmp;
      //  Graphics mg;
        EnVentas _enVentas = new EnVentas();
        VentasBL _ventasBL = new VentasBL();
        InventarioBL _inventarioBL = new InventarioBL();
        Inventario _enInventario = new Inventario();
        double douTotalSumaProductos = 0;
        double douTotalSumaProductosCredito = 0;

        public FVentas()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);



        private void bRegresar_Click(object sender, EventArgs e)
        {
            FMenuEmpleado _fPrincipal = new FMenuEmpleado();
            _fPrincipal.Show();
            this.Close();
        }

        private void FVentas_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        // Programacion OP

        private void bVenta_Click(object sender, EventArgs e)
        {

            try
            {
                if (FdFechaSalida.Text == "" || FcNombreCliente.Text == "" || FcDomicilio.Text == "" || FcCiudad.Text == "" || FcTelefono.Text == "" || FdFechaPago.Text == "" || txtCantidad.Text == "" || txtPrecioDeContado.Text == "" || txtPrecioACredito.Text==""|| txtImporte.Text == "")

                   // if (FdFechaSalida.Text == "" || FcNombreCliente.Text == "" || FcDomicilio.Text == "" || FcCiudad.Text == "" || FcTelefono.Text == "" || FdFechaPago.Text == "" || txtCantidad.Text == "" || FcConcepto.Text == "" || txtPrecioUnitario.Text == "" || txtImporte.Text == "")
                {
                    MessageBox.Show("Parece que olvidaste llenar todos los campos", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    _enVentas.fDtFechaSalida = FdFechaSalida.Text;
                    _enVentas.fcNombreCliente = FcNombreCliente.Text;
                    _enVentas.fcDomicilio = FcDomicilio.Text;
                    _enVentas.fcCiudad = FcCiudad.Text;
                    _enVentas.fcTelefono = FcTelefono.Text;
                    _enVentas.fcFechaPago = FdFechaPago.Text;
                    _enVentas.fiCantidad = int.Parse(txtCantidad.Text);
                   // _enVentas.fcConcepto = FcConcepto.Text;
                    _enVentas.fdPrecioUnitario = decimal.Parse(txtPrecioUnitario.Text);
                    _enVentas.fdImporte = decimal.Parse(txtImporte.Text);
                    _enVentas.fdTotal = decimal.Parse(FdTotal.Text);
                
                    int Resultado = _ventasBL.AgregarVenta(_enVentas);

                    if (Resultado == 1)
                    {
                        MessageBox.Show("Se Agrego El Nuevo Producto Correctamente", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Limpiar();
                        Limpiar_Venta();
                    }

                }
            }

            catch (Exception)
            {

                MessageBox.Show("Hubo un error al Agregar el Producto", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
 
        }

        private void btConsultarVentas_Click(object sender, EventArgs e)
        {
            dgProductos.DataSource = _ventasBL.MostrarVentas();
        }
       
        private void bBusqueda_Click(object sender, EventArgs e)
        {
            if (!(FcConcepto.Text == ""))
            {
                _enInventario.NombreProducto = FcConcepto.Text;
                dgProductos.DataSource = _inventarioBL.MostrarInventarioPorNombre(_enInventario);
            }
            //dgProductos.DataSource = _inventarioBL.MostrarInventario();
        }

        private void Limpiar()
        {
            FdFechaSalida.Text = string.Empty;
            FcNombreCliente.Text = string.Empty;
            FcDomicilio.Text = string.Empty;
            FcCiudad.Text = string.Empty;
            FcTelefono.Text = string.Empty;
            FdFechaPago.Text = string.Empty;
            FdFechaSalida.Focus();
        }

        private void Limpiar_Venta()
        {
            txtNombre.Text = string.Empty;
            txtCantidad.Text = string.Empty;
            txtPrecioUnitario.Text = string.Empty;
            txtImporte.Text = string.Empty;
            txtNombre.Focus();

        }
        private void bLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
           
        }

        private void dgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {//Los campos seran de inventario o de ventas.!?  Creo que eran de inventario asi que fue de Inventario, Será necesario hacer un if para eso de los precios.!?
            // no se que dices jaja
            string strCantidad = txtCantidad.Text.ToString().Trim();
            txtNombre.Text = dgProductos.Rows[e.RowIndex].Cells["NombreProducto"].Value.ToString();          
            txtPrecioUnitario.Text = dgProductos.Rows[e.RowIndex].Cells["CostoUnitario"].Value.ToString();
            txtPrecioACredito.Text = dgProductos.Rows[e.RowIndex].Cells["PrecioACredito"].Value.ToString();
            txtPrecioDeContado.Text = dgProductos.Rows[e.RowIndex].Cells["PrecioContado"].Value.ToString();
            // txtPrecioUnitario.Text = dgProductos.Rows[e.RowIndex].Cells["PrecioContado"].Value.ToString();//Precio Contado o Precio Credito //Precio depende del tipo de venta      
            // txtPrecioUnitario.Text = dgProductos.Rows[e.RowIndex].Cells["PrecioContado"].Value.ToString();//Precio Contado o Precio Credito //Precio depende del tipo de venta      
            string strPrecio = txtPrecioUnitario.Text.ToString().Trim();
                        
    
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                double intCantidadProducto;               
                double doTotalDelProducto;
                double doTotalDelProductoCredito;
                string strNombreProductos;
            

                if (!txtNombre.Text.Equals(""))
                    {

                        if (txtCantidad.Text.Equals(""))
                        {
                            MessageBox.Show("Debe Colocar la cantidad que desea Vender");
                        }
                        else
                        {

                            intCantidadProducto = double.Parse(txtCantidad.Text.ToString().Trim());
                            double intProductoUnitario = double.Parse(txtPrecioUnitario.Text.ToString().Trim());
                            double doProductoUnitarioCredito = double.Parse(txtPrecioACredito.Text.ToString().Trim());
                            doTotalDelProducto = intProductoUnitario * intCantidadProducto;
                            doTotalDelProductoCredito = doProductoUnitarioCredito * intCantidadProducto;
                            txtImporte.Text = doTotalDelProducto.ToString();
                            this.Controls.Add(dgTotalProductos);
                            strNombreProductos = txtNombre.Text.ToString().Trim();


                        if (dgTotalProductos.Columns.Count == 0)
                        {
                            DataGridViewTextBoxColumn colNombreProducto = new DataGridViewTextBoxColumn();
                            colNombreProducto.HeaderText = "Nombre del Producto";
                            colNombreProducto.Width = 80;
                            dgTotalProductos.Columns.Add(colNombreProducto);

                            DataGridViewTextBoxColumn colCantidadProducto = new DataGridViewTextBoxColumn();
                            colCantidadProducto.HeaderText = "Cantidad";
                            colCantidadProducto.Width = 80;
                            dgTotalProductos.Columns.Add(colCantidadProducto);


                            DataGridViewTextBoxColumn colTotalProducto = new DataGridViewTextBoxColumn();
                            colTotalProducto.HeaderText = "Precio Total Unitario";
                            colTotalProducto.Width = 80;
                            dgTotalProductos.Columns.Add(colTotalProducto);

                            
                            DataGridViewTextBoxColumn colCantidadProductoCredito = new DataGridViewTextBoxColumn();
                            colCantidadProductoCredito.HeaderText = "Precio Total A Credito";
                            colCantidadProductoCredito.Width = 80;
                            dgTotalProductos.Columns.Add(colCantidadProductoCredito);
                                                       

                            dgTotalProductos.Rows.Add(doTotalDelProducto, intCantidadProducto, doTotalDelProductoCredito, strNombreProductos);

                                                        
                        }
                        else {                            
                            dgTotalProductos.Rows.Add(doTotalDelProducto, intCantidadProducto, doTotalDelProductoCredito, strNombreProductos);

                        }

                        douTotalSumaProductos = douTotalSumaProductos + doTotalDelProducto;
                        douTotalSumaProductosCredito = douTotalSumaProductosCredito + doTotalDelProductoCredito;
                        FdTotal.Text = douTotalSumaProductos.ToString();
                        txtTotalAPagarCredito.Text = douTotalSumaProductosCredito.ToString();

                    }

                    }                  

                
                else
                {
                    MessageBox.Show("Debe seleccionar un Producto Primero");
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Limpiar_Venta();
        }

        private void btnImprimirVenta_Click(object sender, EventArgs e)
        {
           
            // AQUI~~~ necesito ayuda!!!!!

            if (!FdFechaPago.Equals(string.Empty) )
            {

                _enVentas.fDtFechaSalida = FdFechaSalida.Text.ToString();
                _enVentas.fcNombreCliente = FcNombreCliente.Text.ToString();
                _enVentas.fcDomicilio = FcDomicilio.Text.ToString();
                _enVentas.fcCiudad = FcCiudad.Text.ToString();
                _enVentas.fcTelefono = FcTelefono.Text.ToString();
                _enVentas.fcFechaPago = FcDomicilio.Text.ToString();
              //_enVentas.fiCantidad = txtCantidad.Text.ToString(); // de prueba
                _enVentas.fiCantidad = 1;
                _enVentas.fcConcepto = FcConcepto.Text.ToString();
                _enVentas.fdPrecioUnitario = decimal.Parse(FdTotal.Text);                
                _enVentas.fdTotal = decimal.Parse(FdTotal.Text);
                _enVentas.fdImporte = decimal.Parse(txtTotalAPagarCredito.Text);

                int RespuestaTipoVenta = _ventasBL.AgregarVenta(_enVentas);

                FNotaVenta _FNotaVenta = new FNotaVenta();
                _FNotaVenta.Show();
            }
            else
            {
                MessageBox.Show("favor de llenar todos los campos ");
            }

           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            PrevioImprecion.Document = ImprecionNota;            
            PrevioImprecion.ShowDialog();
        }

        private void ImprecionNota_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            FNotaVenta _FNotaVenta = new FNotaVenta();
            Image bmp = _FNotaVenta.CaptureScreen();
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
