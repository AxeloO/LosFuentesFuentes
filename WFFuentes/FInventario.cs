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
using System.Runtime.InteropServices;

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

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);

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
                    _en.PrecioContado = decimal.Parse(txtPrecioDeContado.Text);
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

                MessageBox.Show("Hubo un error al Agregar el Producto", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            txtCantidad.Text = string.Empty;
            txtCostoUnitario.Text = string.Empty;
            txtGrupoPerteneciente.Text = string.Empty;
            txtNombreDelProducto.Text = string.Empty;
            txtPorcentajeDeContado.Text = string.Empty;
            txtPorcentajePrecioCredito.Text = string.Empty;
            txtPrecioCredito.Text = string.Empty;
            txtPrecioDeContado.Text = string.Empty;
            cbPresentacion.Text = string.Empty;

            txtNombreDelProducto.Focus();

        }

        private void dgInventario_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {

                _en = dgInventario.DataSource as Inventario;
                

                if (_en != null)
                {

                    // txtNombreDelProducto.Text = dgInventario.DataSource as Inventario;

                    txtNombreDelProducto.Text = _en.NombreProducto;
                    txtCantidad.Text = Convert.ToString(_en.Cantidad);
                    txtGrupoPerteneciente.Text = _en.GrupoPerteneciente;
                    txtCostoUnitario.Text = Convert.ToString(_en.CostoUnitario);
                    txtPorcentajeDeContado.Text = Convert.ToString(_en.PorcentajeGananciaContado);
                    txtPorcentajePrecioCredito.Text = Convert.ToString(_en.PorcentajeGananciaCredito);
                    txtPrecioDeContado.Text = Convert.ToString(_en.PrecioContado);
                    txtPrecioCredito.Text = Convert.ToString(_en.PrecioACredito);
                    cbPresentacion.Text = Convert.ToString(_en.Presentacion);

                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void btConsulta_Click(object sender, EventArgs e)
        {
            //if (!(txtNombreDelProducto.Text == ""))
            {
               
                dgInventario.DataSource = _inventarioBl.MostrarInventario();
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (txtIdProducto.Text !="" && txtNombreDelProducto.Text != "" && txtGrupoPerteneciente.Text != "")
            {
                DialogResult r = MessageBox.Show("Estas seguro de eliminar este registro?","Alerta!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (r == DialogResult.OK)
                {
                    _inventarioBl.EliminarProducto(_en);
                    dgInventario.Refresh();
                    dgInventario.DataSource = _inventarioBl.MostrarInventario();
                }
                if (r==DialogResult.Cancel)
                {
                    
                }

            }

            if (_inventarioBl.EliminarProducto(_en) > 0)//if (_inventarioBl.ModificarProducto(_en) > 0)
            {

            }
        }
        
        private void btModificar_Click(object sender, EventArgs e)
        {
            if (txtNombreDelProducto.Text != "" && txtGrupoPerteneciente.Text != "")
            {
                _en.NombreProducto = txtNombreDelProducto.Text;
                _en.GrupoPerteneciente = txtGrupoPerteneciente.Text;
                _en.PorcentajeGananciaContado = decimal.Parse(txtPorcentajeDeContado.Text);
                _en.PorcentajeGananciaCredito = decimal.Parse(txtPorcentajePrecioCredito.Text);
                _en.PrecioACredito = decimal.Parse(txtPrecioCredito.Text);
                _en.PrecioContado = decimal.Parse(txtPrecioDeContado.Text);
                _en.Cantidad = Int32.Parse(txtCantidad.Text);
                _en.CostoUnitario = decimal.Parse(txtCostoUnitario.Text);
                _en.Presentacion = cbPresentacion.Text;

                if (_inventarioBl.ModificarProducto(_en) > 0)
                {
                    MessageBox.Show("Se modifico correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    dgInventario.Refresh();
                    dgInventario.DataSource = _inventarioBl.MostrarInventario();
                }

                else
                {
                    MessageBox.Show("Ocurrio un problema, no se pudo modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Seleccione un Registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void FCuentasCobrar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);       
        }

        private void bRegresar_Click(object sender, EventArgs e)
        {
            FMenuClientes _fPrincipal = new FMenuClientes();
            _fPrincipal.Show();
            this.Close();
        }

        private void FInventario_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
