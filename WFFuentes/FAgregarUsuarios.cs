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
            try
            {
                

                if (txtNombreEmpleado.Text == "" || txtNombreUsuario.Text == "" || txtContraseña.Text == "" || cbTipoUsuario.Text == "" )
                {
                    MessageBox.Show("Parece que olvidaste llenar todos los campos", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    _enUsuario.fcNombreCompleto = txtNombreEmpleado.Text;
                    _enUsuario.fcNombreUsuario = txtNombreUsuario.Text;
                    _enUsuario.fcPassword = txtContraseña.Text;
                    _enUsuario.fiIdUsuario = int.Parse(cbTipoUsuario.Text);
                   

                    int Resultado = _usuariosBL.AgregarUsuario(_enUsuario);

                    if (Resultado == 1)
                    {
                        MessageBox.Show("Se Agrego El Nuevo Producto Correctamente", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }

                }
            }

            catch (Exception)
            {

                MessageBox.Show("Hubo un error al Agregar el Producto", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
