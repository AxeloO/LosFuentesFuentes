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
    }
}
