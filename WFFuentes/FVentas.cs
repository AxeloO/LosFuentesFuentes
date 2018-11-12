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

        EnVentas _enVentas = new EnVentas();
        VentasBL _ventasBL = new VentasBL();
        InventarioBL _inventarioBL = new InventarioBL();
        Inventario _enInventario = new Inventario();
        double douTotalSumaProductos = 0;

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
                if (FdFechaSalida.Text == "" || FcNombreCliente.Text == "" || FcDomicilio.Text == "" || FcCiudad.Text == "" || FcTelefono.Text == "" || FdFechaPago.Text == "" || txtCantidad.Text == "" || txtPrecioUnitario.Text == "" || txtImporte.Text == "")

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
            txtPrecioUnitario.Text = dgProductos.Rows[e.RowIndex].Cells["PrecioContado"].Value.ToString();//Precio Contado o Precio Credito //Precio depende del tipo de venta           
           // txtPrecioUnitario.Text = dgProductos.Rows[e.RowIndex].Cells["PrecioContado"].Value.ToString();//Precio Contado o Precio Credito //Precio depende del tipo de venta      
           // txtPrecioUnitario.Text = dgProductos.Rows[e.RowIndex].Cells["PrecioContado"].Value.ToString();//Precio Contado o Precio Credito //Precio depende del tipo de venta      
            string strPrecio = txtPrecioUnitario.Text.ToString().Trim();
                        
    
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                              
                int intCantidadProducto;               
                double doTotalDelProducto;                              

                    if (!txtNombre.Text.Equals(""))
                    {

                        if (txtCantidad.Text.Equals(""))
                        {
                            MessageBox.Show("Debe Colocar la cantidad que desea Vender");
                        }
                        else
                        {

                            intCantidadProducto = int.Parse(txtCantidad.Text.ToString().Trim());
                            int intProductoUnitario = int.Parse(txtPrecioUnitario.Text.ToString().Trim());
                            doTotalDelProducto = intProductoUnitario * intCantidadProducto;
                            txtImporte.Text = doTotalDelProducto.ToString();
                            this.Controls.Add(dgTotalProductos);


                        if (dgTotalProductos.Columns.Count == 0)
                        {



                            DataGridViewTextBoxColumn colTotalProducto = new DataGridViewTextBoxColumn();
                            colTotalProducto.HeaderText = "Precio Total Unitario";
                            colTotalProducto.Width = 200;
                            dgTotalProductos.Columns.Add(colTotalProducto);

                            DataGridViewTextBoxColumn colCantidadProducto = new DataGridViewTextBoxColumn();
                            colCantidadProducto.HeaderText = "Cantidad";
                            colCantidadProducto.Width = 200;
                            dgTotalProductos.Columns.Add(colCantidadProducto);

                            //DataGridViewTextBoxColumn colTotalProductoContado = new DataGridViewTextBoxColumn();
                            //colCantidadProducto.HeaderText = "Precio Total al Contado";
                            //colCantidadProducto.Width = 200;
                            //dgTotalProductos.Columns.Add(colCantidadProducto);

                            //DataGridViewTextBoxColumn colTotalProductoCredito = new DataGridViewTextBoxColumn();
                            //colCantidadProducto.HeaderText = "Precio Total a Credito";
                            //colCantidadProducto.Width = 200;
                            //dgTotalProductos.Columns.Add(colCantidadProducto);

                            dgTotalProductos.Rows.Add(doTotalDelProducto, intCantidadProducto);


                            
                        }
                        else {                            
                            dgTotalProductos.Rows.Add(doTotalDelProducto, intCantidadProducto);

                        }

                        douTotalSumaProductos = douTotalSumaProductos + doTotalDelProducto;

                        FdTotal.Text = douTotalSumaProductos.ToString();
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

       

        private void FdTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }


        //private void dgProductos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        //{
        //      string strNombreDeProducto = string.Empty;
        //        int iCantidad = 0;
        //          decimal dPrecioUnitario = 0;
        //            decimal dImporte = 0;

        //if (dgProductos != null)
        //{

        //  strNombreDeProducto = dgProductos.ro;

        //}

        //  iCantidad = int.Parse(FcCantidad.Text);
        //}
    }
}
