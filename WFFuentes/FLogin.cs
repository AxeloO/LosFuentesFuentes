using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using EN;
using BL;

namespace WFFuentes
{
    public partial class FLogin : Form
    {
        EnUsuario _enUsuario = new EnUsuario();
        UsuariosBL _usuarioBl = new UsuariosBL();

        public FLogin()
        {
            InitializeComponent();
            
        }
       

        private void BEntrar_Click(object sender, EventArgs e)
        {
           

            List<EnUsuario> ListaDeUsuarios = new List<EnUsuario>();
            
            string strResUsuario = txtNombreUsuario.Text.ToString().Trim();
            string strResPassword = txtContraseña.Text.ToString().Trim();
            
            foreach (EnUsuario Usuario in _usuarioBl.ListaDeUsuarios())
            {
               string strUsuarios = Usuario.fcNombreUsuario.ToString().Trim();
               string strPassword  = Usuario.fcPassword.ToString().Trim();
               string strPuesto = Usuario.fiPuestoUsuario.ToString();

              
               
                    if (strUsuarios.Equals(strResUsuario) && strPassword.Equals(strResPassword))
                    {

                                        
                        if (strPuesto.Equals("420")) 
                        {
                            FInventario _fInventario = new FInventario();
                            this.Close();
                            _fInventario.ShowDialog();
                        }
                        else if (strPuesto.Equals("720"))
                        {
                            FInventario _fInventario = new FInventario();
                            this.Close();
                            _fInventario.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("el Puesto es incorrecto");

                        }
                                            
                    
                }
                else
                {
                    MessageBox.Show("Usuario o Contrasena Incorrecta");
                }
               
            }

            

        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

       
    }
}
