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
    public partial class FMenuEmpleado : Form
    {
        public FMenuEmpleado()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);

        private void bVentas_Click(object sender, EventArgs e)
        {
            Form _fVender = new FVentas();
            _fVender.Show();
            this.Close();
        }

        private void bConsultaAlmacen_Click(object sender, EventArgs e)
        {
            Form _fConsulta = new FConsultaAlmacen();
            _fConsulta.Show();
            this.Close();
        }

        private void bDevolucion_Click(object sender, EventArgs e)
        {
            Form _fRegistro = new FDevoluciones();
            _fRegistro.Show();
            this.Close();
        }

        private void bConsultaCliente_Click(object sender, EventArgs e)
        {
            Form _fConsulta = new FConsultaClientes();
            _fConsulta.Show();
            this.Close();
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FMenuEmpleado_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

       
    }
}
