using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Runtime.InteropServices;

using EN;
using BL;

namespace WFFuentes
{
    public partial class FNotaVenta : Form
    {
        Bitmap bmp;
        EnVentas _enVentas = new EnVentas();
        VentasBL _ventasBL = new VentasBL();
        InventarioBL _inventarioBL = new InventarioBL();
        Inventario _enInventario = new Inventario();


        public FNotaVenta()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);

        private void FNotaVenta_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public Image CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, myGraphics);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
           // PrevioImprecion.ShowDialog();

            return bmp;

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printDocument1.PrinterSettings.PrinterName = "nombreimpresora";//Impresora de punto
            printDocument1.Print();
        }

        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {
            try
            {
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al imprimir. Favor de salir e ingresar nuevamente a la opción", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.panelImprimir.Width, this.panelImprimir.Height);
            panelImprimir.DrawToBitmap(bm, new Rectangle(0, 0, this.panelImprimir.Width, this.panelImprimir.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void llenarNota(EnVentas enVentas, DataGridView dgTotalProductos)
        {
            int iteracion = 1;
            string strTodosLosProductos = String.Empty;

            txbFecha.Text = enVentas.fDtFechaSalida.ToString();
            txtNombre.Text = enVentas.fcNombreCliente.ToString();
            txtDomicilio.Text = enVentas.fcDomicilio.ToString();
            txtCiudad.Text = enVentas.fcCiudad.ToString();
            txtTelefono.Text = enVentas.fcTelefono.ToString();
            txtFechaFinal.Text = enVentas.fcFechaPago.ToString();


            foreach (DataGridViewRow producto in dgTotalProductos.Rows)
            {
                if (iteracion < dgTotalProductos.RowCount)
                {

                    strTodosLosProductos = strTodosLosProductos +"\n"+ producto.Cells[1].Value.ToString();


                }
                iteracion++;
            }

            txbProducto.Text = strTodosLosProductos;
            ShowDialog();
        }

        
    }
}
