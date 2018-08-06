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

        
    }
}
