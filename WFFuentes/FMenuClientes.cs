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
    public partial class FMenuClientes : Form
    {
        public FMenuClientes()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);


        private void FMenuClientes_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FMenuClientes _fAdmon = new FMenuClientes();
            _fAdmon.ShowDialog();
        }

        private void agregarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form _fAgregar = new FAgregarCliente();
            _fAgregar.Show();
            this.Close();


        }

        private void eliminarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form _fEliminar = new FModificarCliente();
            _fEliminar.Show();
            this.Close();

        }

        private void modificarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form _fModificar = new FModificarCliente();
            _fModificar.Show();
            this.Close();

        }
        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
