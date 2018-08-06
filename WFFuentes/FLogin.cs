using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WFFuentes
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
            
        }
       

        private void BEntrar_Click(object sender, EventArgs e)
        {
            FInventario _fInventario = new FInventario();                       
            _fInventario.Show();
            this.Close();



        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
