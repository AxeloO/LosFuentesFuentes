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
                dgInventario.DataSource = _bl.MostrarInventarioPorNombre(_en);
                
                
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
    }
}
