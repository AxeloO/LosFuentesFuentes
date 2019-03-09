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
    public partial class FConsultaAlmacen : Form
    {
        Inventario _en = new Inventario();
        InventarioBL _bl = new InventarioBL();

        public FConsultaAlmacen()
        {
            InitializeComponent();
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            if (!(txtBusquedaProducto.Text ==""))
            {
                _en.NombreProducto = txtBusquedaProducto.Text;
                dgInventario.DataSource = _bl.MostrarInventarioPorNombreEmpleado(_en);
                txtBusquedaProducto.Text = string.Empty;
                
            }
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);

        private void FConsultaAlmacen_MouseDown(object sender, MouseEventArgs e)
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

        private void bActualizar_Click(object sender, EventArgs e)
        {
            dgInventario.DataSource = _bl.MostrarInventarioEmpleado();

        }

        private void bImprimir_Click(object sender, EventArgs e)//Agregado para imprimir 08/03/19
        {
            printDocument1.PrinterSettings.PrintFileName = "NPI099E21(HP Color LaserJet MFPm377dw)";
            printDocument1.Print();
        }

        private void FConsultaAlmacen_Load(object sender, EventArgs e)
        {

        }

        private void bVistaprevia_Click(object sender, EventArgs e)//Agregado para vista previa 08/03/19
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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)//Agregado para imprimir 08/03/19
        {
            Bitmap bm = new Bitmap(this.dgInventario.Width, this.dgInventario.Height);
            dgInventario.DrawToBitmap(bm, new Rectangle(0, 0, this.dgInventario.Width, this.dgInventario.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
    }
}
