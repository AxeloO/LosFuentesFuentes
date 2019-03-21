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
                    MessageBox.Show("Parece que olvidaste llenar algunos de los campos", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                     _enCliente.FcNombreCompleto= txtNombreCompleto.Text;
                     _enCliente.FcDomicilio= txtDomicilio.Text;
                     _enCliente.FiTelefono = txtTelefono.Text;
                     _enCliente.FcRFC = txtRFC.Text;
                     _enCliente.FcTipoCredito = txtTipoCredito.Text;
                     _enCliente.FcTipoGarantia = txtGarantia.Text;
                     _enCliente.FdLimiteCredito = decimal.Parse(txtLimiteCredito.Text);

                    int Resultado = _clientesBL.AgregarClientes(_enCliente);
                    dGClientes.Refresh();
                    dGClientes.DataSource = _clientesBL.MostrarClientes();

                    if (Resultado == 1)
                    {
                        MessageBox.Show("Se agrego el nuevo cliente correctamente", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Limpiar();
                    } 

                }
            }

            catch (Exception)
             {

                MessageBox.Show("Hubo un error al agregar el cliente", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
        }
        private void Limpiar()
        {
            txtID.Text = string.Empty;
            txtNombreCompleto.Text = string.Empty;
            txtDomicilio.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtRFC.Text = string.Empty;
            txtTipoCredito.Text = string.Empty;
            txtGarantia.Text = string.Empty;
            txtLimiteCredito.Text = string.Empty;
            txtNombreCompleto.Focus();//Posiciona en el textbox principal

        }
        private void bLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();

        }

        private void bConsultar_Click(object sender, EventArgs e)
        {
            dGClientes.DataSource = _clientesBL.MostrarClientes();
           
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string strIdCliente = txtID.Text.ToString().Trim();
                if (strIdCliente != "" && txtNombreCompleto.Text != "")
                {
                    DialogResult r = MessageBox.Show("¿Estas seguro de eliminar este registro?", "¡Advertencia!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (r == DialogResult.OK)
                    {
                        long longIdClientes = long.Parse(strIdCliente);

                        _enCliente.FiIdCliente = longIdClientes;
                        _clientesBL.EliminarCliente(_enCliente);
                        dGClientes.Refresh();
                        dGClientes.DataSource = _clientesBL.MostrarClientes();
                        Limpiar();
                    }
                    if (r == DialogResult.Cancel)
                    {

                    }
                }
                if (_clientesBL.EliminarCliente(_enCliente) > 0)//if (_inventarioBl.ModificarProducto(_en) > 0)
                {

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            if(txtID.Text !="" && txtNombreCompleto.Text !="")
            {
                _enCliente.FiIdCliente = long.Parse(txtID.Text);
                _enCliente.FcNombreCompleto = txtNombreCompleto.Text;
                _enCliente.FcDomicilio = txtDomicilio.Text;
                _enCliente.FiTelefono = txtTelefono.Text;
                _enCliente.FcRFC = txtRFC.Text;
                _enCliente.FcTipoCredito = txtTipoCredito.Text;
                _enCliente.FcTipoGarantia = txtGarantia.Text;
                _enCliente.FdLimiteCredito = decimal.Parse(txtLimiteCredito.Text);
                if (_clientesBL.ModificarCliente(_enCliente) > 0)
                {
                    MessageBox.Show("El registro se modificó correctamente", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    dGClientes.Refresh();
                    dGClientes.DataSource = _clientesBL.MostrarClientes();
                    Limpiar();

                }
                else
                {
                    MessageBox.Show("No se pudo realizar la acción solicitada", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
            }
                else
                 {
                MessageBox.Show("Seleccione un registro", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        
        private void bBusqueda_Click(object sender, EventArgs e)
        {
            if (!(txtBusqueda.Text == ""))
            {
                _enCliente.FcNombreCompleto = txtBusqueda.Text;
                dGClientes.DataSource = _clientesBL.MostrarClientePorNombre(_enCliente);
            }
            txtBusqueda.Text = string.Empty;
        }

        private void dGClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // dGClientes.Sort(dGClientes.Columns("FcNombreCompleto").ListSortDirection.Ascending);Quiero ordenar los registros 
            txtID.Text = dGClientes.Rows[e.RowIndex].Cells["FiIdCliente"].Value.ToString();
            txtNombreCompleto.Text = dGClientes.Rows[e.RowIndex].Cells["FcNombreCompleto"].Value.ToString();
            txtDomicilio.Text = dGClientes.Rows[e.RowIndex].Cells["FcDomicilio"].Value.ToString();
            txtTelefono.Text = dGClientes.Rows[e.RowIndex].Cells["FiTelefono"].Value.ToString();
            txtRFC.Text = dGClientes.Rows[e.RowIndex].Cells["FcRFC"].Value.ToString();
            txtTipoCredito.Text = dGClientes.Rows[e.RowIndex].Cells["FcTipoCredito"].Value.ToString();
            txtGarantia.Text = dGClientes.Rows[e.RowIndex].Cells["FcTipoGarantia"].Value.ToString();
            txtLimiteCredito.Text = dGClientes.Rows[e.RowIndex].Cells["FdLimiteCredito"].Value.ToString();            
        }

        private void FAgregarCliente_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtNombreCompleto_TextChanged(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dGClientes.Width, this.dGClientes.Height);
            dGClientes.DrawToBitmap(bm, new Rectangle(0, 0, this.dGClientes.Width, this.dGClientes.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void bImprimir_Click(object sender, EventArgs e)
        {
            printDocument1.PrinterSettings.PrintFileName = "NPI099E21(HP Color LaserJet MFPm377dw)";
            printDocument1.Print();
        }

        private void bVistaprevia_Click(object sender, EventArgs e)//Agregado para la vista previa 08/03/19
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




        // Programacion OP
    }
}

