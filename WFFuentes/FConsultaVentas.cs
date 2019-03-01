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
    public partial class FConsultaVentas : Form
    {
        EnVentas _enVentas = new EnVentas();
        VentasBL _ventasBL = new VentasBL();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);

        public FConsultaVentas()
        {
            InitializeComponent();
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {


            if (!txtFechaI.Text.Equals(""))
            {
                _enVentas.fDtFechaSalida = txtFechaI.Text.ToString().Trim();
                dgVentas.DataSource = _ventasBL.MostrarVentasPorDiaDeSalida(_enVentas);               
            }
            if (!txtFechaF.Text.Equals("") && txtFechaI.Text.Equals(""))
            {
                _enVentas.fcFechaPago = txtFechaF.Text.ToString().Trim();
                dgVentas.DataSource = _ventasBL.MostrarVentasPorDiaDePago(_enVentas);
            }
            if (txtFechaF.Text.Equals("") && txtFechaI.Text.Equals(""))
            {
                MessageBox.Show("Debe elegir la opcion a Buscar (Fecha inicio o fecha de pago)", "¡Favor de Verificar!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            else
            {
                _enVentas.fcConcepto = txtProducto.Text;
                dgVentas.DataSource = _ventasBL.MostrarVentasPorDia(_enVentas);
            }
                        
        }

        private void FConsultaVentas_MouseDown(object sender, MouseEventArgs e)
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

        private void bActualizar_Click(object sender, EventArgs e)
        {
            dgVentas.DataSource = _ventasBL.MostrarVentas();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dgVentas.Width, this.dgVentas.Height);
            dgVentas.DrawToBitmap(bm, new Rectangle(0, 0, this.dgVentas.Width, this.dgVentas.Height));
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
                MessageBox.Show("Ocurrio un error al imprimir. Favor de salir e ingresar nuevamente a la opción", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void bImprimir_Click(object sender, EventArgs e)
        {
            printDocument1.PrinterSettings.PrinterName = "NPI";
            printDocument1.Print();
        }


    }
}
