﻿using System;
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

using EN;
using BL;

namespace WFFuentes
{
    public partial class FNotaVenta : Form
    {
        Bitmap bmp;
        EnVentas _enVentas = new EnVentas();
        VentasBL _ventasBL = new VentasBL();
        InventarioBL _inventarioBL = new InventarioBL();
        Inventario _enInventario = new Inventario();


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
            printDocument1.PrinterSettings.PrinterName = "EPSON LX-350 ESC/P";//Impresora de punto
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

        public void llenarNota(EnVentas enVentas, DataGridView dgTotalProductos, string strTipoDeVenta, string TotalTipo)
        {
            
            string strTodosLosNombresDeProductos = String.Empty;
            string strTodosLosPreciosDeProductosContado = String.Empty;
            string strTodosLosPreciosDeProductosACredito = String.Empty;
            //string StrTodosLosPreciosDeProductos = String.Empty;
            string StrTodasLasCantidadesDeProductos = String.Empty;
            string strTodosLosPreciosUnitariosDeProductosContado = String.Empty;//Agregado para mandar los precios unitarios por producto de contado.. 21/03/19
            string strTodosLosPreciosUnitariosDeProductosCredito = String.Empty;//Agregado para mandar los precios unitarios por producto de credito.. 21/03/19

            txbFecha.Text = enVentas.fDtFechaSalida.ToString();
            txtNombre.Text = enVentas.fcNombreCliente.ToString();
            txtDomicilio.Text = enVentas.fcDomicilio.ToString();
            txtCiudad.Text = enVentas.fcCiudad.ToString();
            txtTelefono.Text = enVentas.fcTelefono.ToString();
            txtFechaFinal.Text = enVentas.fcFechaPago.ToString();


            foreach (DataGridViewRow producto in dgTotalProductos.Rows)
            {

                strTodosLosPreciosDeProductosContado = strTodosLosPreciosDeProductosContado + Environment.NewLine+ producto.Cells[3].Value.ToString();
                strTodosLosPreciosDeProductosACredito = strTodosLosPreciosDeProductosACredito + Environment.NewLine + producto.Cells[4].Value.ToString();
                StrTodasLasCantidadesDeProductos = StrTodasLasCantidadesDeProductos + Environment.NewLine + producto.Cells[2].Value.ToString();
                strTodosLosNombresDeProductos = strTodosLosNombresDeProductos + Environment.NewLine + producto.Cells[1].Value.ToString();
                strTodosLosPreciosUnitariosDeProductosContado = strTodosLosPreciosUnitariosDeProductosContado + Environment.NewLine + producto.Cells[5].Value.ToString();//Agregado para guardar los precios por producto de contado.. 21/03/19
                strTodosLosPreciosUnitariosDeProductosCredito = strTodosLosPreciosUnitariosDeProductosCredito + Environment.NewLine + producto.Cells[6].Value.ToString();//Agregado para mandar los precios unitarios por producto de credito.. 21/03/19

            }

            txbUnidad.Text = StrTodasLasCantidadesDeProductos;
            txbConcepto.Text = strTodosLosNombresDeProductos;
            //txbCantidad.Text = StrTodasLasCantidadesDeProductos;//No es la cantidad nuevamente sino los precios por producto.. 21/03/19..
            

            if (strTipoDeVenta.Equals("1"))//Venta al contado 21/03/19..
            {
                txtTotal.Text = TotalTipo.ToString();
                txbImporte.Text = strTodosLosPreciosDeProductosContado;
                txbCantidad.Text = strTodosLosPreciosUnitariosDeProductosContado;//Agregado haber que hace 21/03/19..
            }
            if (strTipoDeVenta.Equals("2"))//Venta a Credito 21/03/19..
            {
                txtTotal.Text = TotalTipo.ToString();
                txbImporte.Text = strTodosLosPreciosDeProductosACredito;
                txbCantidad.Text = strTodosLosPreciosUnitariosDeProductosCredito;//Agregado haber que hace 21/03/19..
            }

            ShowDialog();
        }

    }
}
