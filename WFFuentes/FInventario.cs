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
    public partial class FInventario : Form
    {
        Inventario _en = new Inventario();
        InventarioBL _inventarioBl = new InventarioBL();

        
        public FInventario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cbPresentacion.DisplayMember = "Text";
                cbPresentacion.ValueMember = "Value";


                cbPresentacion.Items.Add(new { Text = "Liquidos", Value = "Liquidos" });

                if (txtNombreDelProducto.Text == "" || txtCantidad.Text == "" || txtCostoUnitario.Text == "" || txtGrupoPerteneciente.Text == "" || txtPorcentajeDeContado.Text == "" || txtPorcentajePrecioCredito.Text == "" || txtPrecioCredito.Text == "" || txtPrecioDeContado.Text == "" || cbPresentacion.Text == "")
            {
                MessageBox.Show("Parece que olvidaste llenar todos los campos", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

               

            else
            {
                _en.Cantidad = int.Parse(txtCantidad.Text);
                _en.CostoUnitario = int.Parse(txtCostoUnitario.Text);
                _en.GrupoPerteneciente = txtGrupoPerteneciente.Text;
                _en.NombreProducto = txtNombreDelProducto.Text;
                _en.PorcentajeGananciaContado = decimal.Parse(txtPorcentajeDeContado.Text);
                _en.PorcentajeGananciaCredito = decimal.Parse(txtPorcentajePrecioCredito.Text);
                _en.PrecioACredito = decimal.Parse(txtPrecioCredito.Text);
                _en.Presentacion = cbPresentacion.Text;

                int Resultado = _inventarioBl.AgregarProductos(_en);

                if (Resultado == 1)
                {
                    MessageBox.Show("Se Agrego El Nuevo Producto Correctamente", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

            }
        }
            
            catch (Exception)
            {

                MessageBox.Show("Hubo un error al Agregar el Producto" , "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

       
    }
}
