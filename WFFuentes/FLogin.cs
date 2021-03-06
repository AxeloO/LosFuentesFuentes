﻿using System;
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
using System.Runtime.InteropServices;

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
            string strNuevoPuestoRol = string.Empty;
            string strValidacionPuesto = string.Empty;
            string strResUsuario = txtNombreUsuario.Text.ToString().Trim();
            string strResPassword = txtContraseña.Text.ToString().Trim();

            try
            {
                if (!strResPassword.Equals("") || !strResUsuario.Equals(""))
                {

                    List<EnUsuario> ListaDeUsuarios = new List<EnUsuario>();

                    foreach (EnUsuario Usuario in _usuarioBl.ListaDeUsuarios())
                    {
                        string strUsuarios = Usuario.fcNombreUsuario.ToString().Trim();
                        string strPassword = Usuario.fcPassword.ToString().Trim();
                        string strPuesto = Usuario.fiPuestoUsuario.ToString();

                        if (strUsuarios.Equals(strResUsuario) && strPassword.Equals(strResPassword))
                        {

                            if (strPuesto.Equals("420"))
                            {
                                strNuevoPuestoRol = "420";
                                strValidacionPuesto = "Valido";

                            }

                            if (strPuesto.Equals("720"))
                            {
                                strNuevoPuestoRol = "720";
                                strValidacionPuesto = "Valido";
                            }

                        }

                    }

                    if (strValidacionPuesto.Equals("Valido"))
                    {
                        if (strNuevoPuestoRol.Equals("420"))
                        {
                            FMenuClientes _fmenuClientes = new FMenuClientes();
                            this.Close();
                            _fmenuClientes.ShowDialog();
                        }

                        if (strNuevoPuestoRol.Equals("720"))
                        {
                            FMenuEmpleado _fInventario = new FMenuEmpleado();
                            this.Close();
                            _fInventario.ShowDialog();

                        }

                    }
                    else
                    {
                        MessageBox.Show("Usuario o Contraseña Incorrecta" ,"¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                else
                {
                    MessageBox.Show("Debes llenar todos los campos", "¡Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
            }


            catch (Exception)
            {

                throw;
            }
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);

        private void FLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
