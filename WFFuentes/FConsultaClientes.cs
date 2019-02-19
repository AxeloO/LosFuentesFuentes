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
    public partial class FConsultaClientes : Form
    {

        EnCliente _enCliente = new EnCliente();
        ClientesBL _clientesBL = new ClientesBL();

        public FConsultaClientes()
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
            FMenuEmpleado _fPrincipal = new FMenuEmpleado();
            _fPrincipal.Show();
            this.Close();
        }

        private void bActualizar_Click(object sender, EventArgs e)
        {
            dGClientes.DataSource = _clientesBL.MostrarClientes();
        }

        private void bBusqueda_Click(object sender, EventArgs e)
        {
            if (!(txtBusqueda.Text == ""))
            {
                _enCliente.FcNombreCompleto = txtBusqueda.Text;
                dGClientes.DataSource = _clientesBL.MostrarClientePorNombre(_enCliente);
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dGClientes.Width, this.dGClientes.Height);
            dGClientes.DrawToBitmap(bm, new Rectangle(0, 0, this.dGClientes.Width, this.dGClientes.Height));
            e.Graphics.DrawImage(bm, 0, 0);

        }

        private void btVistaPrevia_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Show();
        }

        private void bImprimir_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}
