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
    public partial class FAgregarUsuarios : Form
    {
        EnUsuario _enUsuario = new EnUsuario();
        UsuariosBL _usuariosBL = new UsuariosBL();
  

        public FAgregarUsuarios()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);

        private void FAgregarUsuarios_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            int respuestaTipoEmpleado = 0;
            try
            {
                if (txtNombreEmpleado.Text.Trim() == "" || txtNombreUsuario.Text.Trim() == "" || txtContraseña.Text.Trim() == "" || cbTipoUsuario.Text.Trim() == "" )
                {
                    MessageBox.Show("Parece que olvidaste llenar todos los campos", "Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    _enUsuario.fcNombreCompleto = txtNombreEmpleado.Text;
                    _enUsuario.fcNombreUsuario = txtNombreUsuario.Text;
                    _enUsuario.fcPassword = txtContraseña.Text;
                    //string strTipoUsuario = cbTipoUsuario.SelectedValue.ToString();
                    string strTipoUsuario = cbTipoUsuario.Text.ToString();

                    if (strTipoUsuario.Equals("Administrador"))
                    {
                        respuestaTipoEmpleado = 420;

                        _enUsuario.fiPuestoUsuario = respuestaTipoEmpleado;

                        int Resultado = _usuariosBL.AgregarUsuario(_enUsuario);

                        if (Resultado == 1)
                        {
                            MessageBox.Show("Se agregó usuario tipo administrador", "Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            Limpiar();
                        }
                    }
                   else if (strTipoUsuario.Equals("Empleado"))
                    {
                        respuestaTipoEmpleado = 720;

                        _enUsuario.fiPuestoUsuario = respuestaTipoEmpleado;

                        int Resultado = _usuariosBL.AgregarUsuario(_enUsuario);

                        if (Resultado == 1)
                        {
                            MessageBox.Show("Se agregó usuario tipo empleado", "Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            Limpiar();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al agregar el usuario", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                      
                    }

                }
            }

            catch (Exception)
            {

                MessageBox.Show("Hubo un error al agregar el usuario", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btConsultarUsuarios_Click(object sender, EventArgs e)
        {
            dgUsuarios.DataSource = _usuariosBL.ListaDeUsuarios();                      
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string strIdUsuario = txtIdUsuario.Text.ToString().Trim();

                if (strIdUsuario != "" && txtNombreUsuario.Text != "")
                {
                    DialogResult r = MessageBox.Show("Estas seguro de eliminar este registro?", "Alerta!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (r == DialogResult.OK)
                    {
                        long longIdUsuario = long.Parse(strIdUsuario);

                        _enUsuario.fiIdUsuario = longIdUsuario;

                        _usuariosBL.EliminarUsuario(_enUsuario);
                        dgUsuarios.Refresh();
                        dgUsuarios.DataSource = _usuariosBL.ListaDeUsuarios();
                        Limpiar();
                    }
                    if (r == DialogResult.Cancel)
                    {

                    }

                }

                if (_usuariosBL.EliminarUsuario(_enUsuario) > 0)//if (_inventarioBl.ModificarProducto(_en) > 0)
                {

                }
            }

            catch (Exception)
            {

                throw;
            }
        }

        private void bRegresar_Click(object sender, EventArgs e)
        {
            FMenuClientes _fPrincipal = new FMenuClientes();
            _fPrincipal.Show();
            this.Close();
        }

        private void Limpiar()
        {
            txtIdUsuario.Text = string.Empty;
            txtNombreEmpleado.Text = string.Empty;
            txtNombreUsuario.Text = string.Empty;
            txtContraseña.Text = string.Empty;
            cbTipoUsuario.Text = string.Empty;
            txtNombreEmpleado.Focus();
            
        }

        private void bLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dgUsuarios_SelectionChanged(object sender, EventArgs e)
        {
           //_enUsuario = dgUsuarios.DataSource as FAgregarCliente;
            if (_enUsuario != null)
            {
                txtIdUsuario.Text = Convert.ToString(_enUsuario.fiIdUsuario);
                txtNombreEmpleado.Text = _enUsuario.fcNombreCompleto;
                txtNombreUsuario.Text = _enUsuario.fcNombreUsuario;
                txtContraseña.Text = _enUsuario.fcPassword;
                cbTipoUsuario.Text = Convert.ToString(_enUsuario.fiPuestoUsuario);
                               
            }
        }

        private void dgUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdUsuario.Text = dgUsuarios.Rows[e.RowIndex].Cells["fiIdUsuario"].Value.ToString();
            txtNombreEmpleado.Text = dgUsuarios.Rows[e.RowIndex].Cells["fcNombreCompleto"].Value.ToString();
            txtNombreUsuario.Text = dgUsuarios.Rows[e.RowIndex].Cells["fcNombreUsuario"].Value.ToString();
            txtContraseña.Text = dgUsuarios.Rows[e.RowIndex].Cells["fcPassword"].Value.ToString();
            cbTipoUsuario.Text = dgUsuarios.Rows[e.RowIndex].Cells["fiPuestoUsuario"].Value.ToString();           
        }
    }
}
