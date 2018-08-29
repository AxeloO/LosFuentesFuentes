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
            this.Close();
        }

        private void agregarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form _fAgregar = new FAgregarCliente();
            _fAgregar.Show();
            this.Close();
        }

        private void eliminarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form _fEliminar = new FEliminarCliente();
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

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form _fUsuarios = new FAgregarUsuarios();
            _fUsuarios.Show();
            this.Close();
        }

        private void agregarNuevoRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form _fProveedores = new FAgregarProveedores();
            _fProveedores.Show();
            this.Close();
        }

        private void modificarRegistroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form _fProveedores = new FConsultaProveedor();
            _fProveedores.Show();
            this.Close();
        }

        private void consultarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form _fProveedores = new FEliminarProveedor();
            _fProveedores.Show();
            this.Close();
        }

        private void agregarNuevoRegistroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form _fAgregar = new FInventario();
            _fAgregar.Show();
            this.Close();
        }

        private void modificarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form _fAgregar = new FInventario();
            _fAgregar.Show();
            this.Close();
        }

        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form _fAgregar = new FInventario();
            _fAgregar.Show();
            this.Close();
        }

        private void cuentasPorPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form _fCuentasPagar = new FCuentasPagar();
            _fCuentasPagar.Show();
            this.Close();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bClientes_Click(object sender, EventArgs e)
        {
            Form _fAgregar = new FAgregarCliente();
            _fAgregar.Show();
            this.Close();
        }

        private void bProveedor_Click(object sender, EventArgs e)
        {
            Form _fAgregar = new FAgregarProveedores();
            _fAgregar.Show();
            this.Close();
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bUsuarios_Click(object sender, EventArgs e)
        {
            Form _fAgregar = new FAgregarUsuarios();
            _fAgregar.Show();
            this.Close();
        }

        private void bProductos_Click(object sender, EventArgs e)
        {
            Form _fAgregar = new FInventario();
            _fAgregar.Show();
            this.Close();
        }

        private void bCompras_Click(object sender, EventArgs e)
        {
            Form _fAgregar = new FCuentasPagar();
            _fAgregar.Show();
            this.Close();
        }

        private void MenuPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
