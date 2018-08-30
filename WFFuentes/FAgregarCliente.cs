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
    public partial class FAgregarCliente : Form
    {
        EnCliente _enCliente = new EnCliente();
        ClientesBL _clientesBL = new ClientesBL();

        public FAgregarCliente()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);

        private void FAgregarCliente_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            FMenuClientes _fPrincipal = new FMenuClientes();
            _fPrincipal.Show();
            this.Close();
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            try
            {//Trim sirve para borrar espacios si es que existen 


                String strNombreCliente = txtNombreCompleto.Text.ToString().Trim();
                String strDomicilio = txtDomicilio.Text.ToString().Trim();
                String strTelefono = txtTelefono.Text.ToString().Trim();
                String strRFC = txtRFC.Text.ToString().Trim();
                String strTipoCredito = txtTipoCredito.Text.ToString().Trim();
                String strGarantia = txtGarantia.Text.ToString().Trim();
                String strLimiteCredito = txtLimiteCredito.Text.ToString().Trim();


                if (strNombreCliente.Equals("") || strDomicilio.Equals("") || strTelefono.Equals("") || strRFC.Equals("") || strTipoCredito.Equals("") || strGarantia.Equals("") || strLimiteCredito.Equals(""))
                {
                    MessageBox.Show("Parece que olvidaste llenar todos los campos", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                     _enCliente.FcNombreCompleto= txtNombreCompleto.Text;
                     _enCliente.FcDomicilio= txtDomicilio.Text;
                     _enCliente.FiTelefono = int.Parse(txtTelefono.Text);
                     _enCliente.FcRFC = txtRFC.Text;
                     _enCliente.FcTipoCredito = txtTipoCredito.Text;
                     _enCliente.FcTipoGarantia = txtGarantia.Text;
                     _enCliente.FdLimiteCredito = decimal.Parse(txtLimiteCredito.Text);


                    int Resultado = _clientesBL.AgregarClientes(_enCliente);

                    if (Resultado == 1)
                    {
                        MessageBox.Show("Se Agrego El Nuevo Cliente Correctamente", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }

                }
            }

            catch (Exception)
             {

                MessageBox.Show("Hubo un error al Agregar el Cliente", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void bLimpiar_Click(object sender, EventArgs e)
        {
            txtNombreCompleto.Text = string.Empty;
            txtDomicilio.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtRFC.Text = string.Empty;
            txtTipoCredito.Text = string.Empty;
            txtGarantia.Text = string.Empty;
            txtLimiteCredito.Text = string.Empty;
         
        }

        private void bConsultar_Click(object sender, EventArgs e)
        {
            dGClientes.DataSource = _clientesBL.MostrarClientes();
        }

        // Programacion OP


    }
}
