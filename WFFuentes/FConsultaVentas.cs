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
            if (!(txtProducto.Text == "" || txtFechaI.Text=="" || txtFechaF.Text==""))
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

    }
}
