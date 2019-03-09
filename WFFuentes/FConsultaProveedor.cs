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

namespace WFFuentes
{
    public partial class FConsultaProveedor : Form
    {
        public FConsultaProveedor()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);
        private void FConsultaClientes_MouseDown(object sender, MouseEventArgs e)
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

        private void bBusqueda_Click(object sender, EventArgs e)
        {

        }

        private void bActualizar_Click(object sender, EventArgs e)
        {

        }

        private void bImprimir_Click(object sender, EventArgs e)//Agregado para imprimir 09/03/19
        {
            printDocument1.PrinterSettings.PrintFileName = "NPI099E21(HP Color LaserJet MFPm377dw)";
            printDocument1.Print();
        }

        private void bVistaprevia_Click(object sender, EventArgs e)
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
    }
}
