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

namespace WFFuentes
{
    public partial class FNotaVenta : Form
    {
        Bitmap bmp;

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
            printDocument1.PrinterSettings.PrinterName = "nombreimpresora";
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
    }
}
