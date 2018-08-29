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





                if (FdFechaSalida.Text == "" || FcNombreCliente.Text == "" || FcDomicilio.Text == "" || FcCiudad.Text == "" || FcTelefono.Text == "" || FdFechaPago.Text == "" || FcCantidad.Text == "" || FcConcepto.Text == "" || FdPrecioUnitario.Text == "" || FdImporte.Text == "")
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
                    _enVentas.fiCantidad = int.Parse(FcCantidad.Text);
                    _enVentas.fcConcepto = FcConcepto.Text;
                    _enVentas.fdPrecioUnitario = decimal.Parse(FdPrecioUnitario.Text);
                    _enVentas.fdImporte = decimal.Parse(FdImporte.Text);
                    _enVentas.fdTotal = decimal.Parse(FdTotal.Text);


                    


                    int Resultado = _ventasBL.AgregarVenta(_enVentas);

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

        private void btConsultarVentas_Click(object sender, EventArgs e)
        {
            dgProductos.DataSource = _ventasBL.MostrarVentas();
        }

        private void FcConcepto_TextChanged(object sender, EventArgs e)
        {

        }

        private void dGVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
        private void bBusqueda_Click(object sender, EventArgs e)
        {
            dgProductos.DataSource = _inventarioBL.MostrarInventario();
        }

        private void dgProductos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string strNombreDeProducto = string.Empty;
            int iCantidad = 0;
            decimal dPrecioUnitario = 0;
            decimal dImporte = 0;

            if (dgProductos != null)
            {
                
                strNombreDeProducto = dgProductos.SelectedRows[0].ToString();

            }

            iCantidad = int.Parse(FcCantidad.Text);
        }
    }
}
