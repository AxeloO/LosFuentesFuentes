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
    public partial class bImprimir : Form
    {
        Inventario _en = new Inventario();
        InventarioBL _inventarioBl = new InventarioBL();


        public bImprimir()
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
               // cbPresentacion.Items.Add(new { Text = "Liquidos", Value = "Liquidos" });

                if (txtNombreDelProducto.Text == "" || txtCantidad.Text == "" || txtCostoUnitario.Text == "" || txtGrupoPerteneciente.Text == "" || txtPrecioCredito.Text == "" || txtPrecioDeContado.Text == "" || cbPresentacion.Text == "")
                {
                    MessageBox.Show("Parece que olvidaste llenar todos los campos", "Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _en.Cantidad = int.Parse(txtCantidad.Text);
                    _en.CostoUnitario = int.Parse(txtCostoUnitario.Text);
                    _en.GrupoPertenenciente = txtGrupoPerteneciente.Text;
                    _en.NombreProducto = txtNombreDelProducto.Text;
                   // _en.PorcentajeGananciaContado = decimal.Parse(txtPorcentajeDeContado.Text);
                    //_en.PorcentajeGananciaCredito = decimal.Parse(txtPorcentajePrecioCredito.Text);sadas
                    _en.PrecioACredito = decimal.Parse(txtPrecioCredito.Text);
                    _en.PrecioContado = decimal.Parse(txtPrecioDeContado.Text);
                    _en.Presentacion = cbPresentacion.Text;

                    int Resultado = _inventarioBl.AgregarProductos(_en);

                    if (Resultado == 1)
                    {
                        MessageBox.Show("Se agrego el nuevo producto correctamente", "Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Limpiar();
                    }

                }
            }

            catch (Exception)
            {

                MessageBox.Show("Hubo un error al agregar el producto", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }
         private void Limpiar()
         {
            txtIdProducto.Text = string.Empty;
             txtCantidad.Text = string.Empty;
             txtCostoUnitario.Text = string.Empty;
             txtGrupoPerteneciente.Text = string.Empty;
             txtNombreDelProducto.Text = string.Empty;
             //txtPorcentajeDeContado.Text = string.Empty;
             //txtPorcentajePrecioCredito.Text = string.Empty;
             txtPrecioCredito.Text = string.Empty;
             txtPrecioDeContado.Text = string.Empty;
             cbPresentacion.Text = string.Empty;
             txtNombreDelProducto.Focus();
         }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dgInventario_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            Inventario _en = new Inventario();
            InventarioBL _inventarioBl = new InventarioBL();

            try
            {
                _en = dgInventario.DataSource as Inventario;
                if (_en != null)
                {
                    // txtNombreDelProducto.Text = dgInventario.DataSource as Inventario;
                    txtNombreDelProducto.Text = _en.NombreProducto;
                    txtCantidad.Text = Convert.ToString(_en.Cantidad);
                    txtGrupoPerteneciente.Text = _en.GrupoPertenenciente;
                    txtCostoUnitario.Text = Convert.ToString(_en.CostoUnitario);
                    //txtPorcentajeDeContado.Text = Convert.ToString(_en.PorcentajeGananciaContado);
                    //txtPorcentajePrecioCredito.Text = Convert.ToString(_en.PorcentajeGananciaCredito);
                    txtPrecioDeContado.Text = Convert.ToString(_en.PrecioContado);
                    txtPrecioCredito.Text = Convert.ToString(_en.PrecioACredito);
                    cbPresentacion.Text = Convert.ToString(_en.Presentacion);
                }
            }
            catch (Exception ex)
            {

                throw ex;
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
            try
            {                
                string strIdProducto = txtIdProducto.Text.ToString().Trim();

                if (strIdProducto != "" && txtNombreDelProducto.Text != "")
                {
                    DialogResult r = MessageBox.Show("Estas seguro de eliminar este registro?", "Alerta!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (r == DialogResult.OK)
                    {
                        long longIdProducto = long.Parse(strIdProducto);

                        _en.IdProducto = longIdProducto;

                        _inventarioBl.EliminarProducto(_en);
                        dgInventario.Refresh();
                        dgInventario.DataSource = _inventarioBl.MostrarInventario();
                        Limpiar();
                    }
                    if (r == DialogResult.Cancel)
                    {

                    }

                }

                if (_inventarioBl.EliminarProducto(_en) > 0)//if (_inventarioBl.ModificarProducto(_en) > 0)
                {

                }
            }

            catch (Exception)
            {

                throw;
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

        private void dgInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtIdProducto.Text = dgInventario.Rows[e.RowIndex].Cells["IdProducto"].Value.ToString();
            txtNombreDelProducto.Text = dgInventario.Rows[e.RowIndex].Cells["NombreProducto"].Value.ToString();
            txtGrupoPerteneciente.Text = dgInventario.Rows[e.RowIndex].Cells["GrupoPertenenciente"].Value.ToString();
            //txtPorcentajeDeContado.Text = dgInventario.Rows[e.RowIndex].Cells["PorcentajeGananciaContado"].Value.ToString();
            //txtPorcentajePrecioCredito.Text = dgInventario.Rows[e.RowIndex].Cells["PorcentajeGananciaCredito"].Value.ToString();
            txtPrecioCredito.Text = dgInventario.Rows[e.RowIndex].Cells["PrecioACredito"].Value.ToString();
            txtPrecioDeContado.Text = dgInventario.Rows[e.RowIndex].Cells["PrecioContado"].Value.ToString();
            txtCantidad.Text = dgInventario.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString();
            txtCostoUnitario.Text = dgInventario.Rows[e.RowIndex].Cells["CostoUnitario"].Value.ToString();
            cbPresentacion.Text = dgInventario.Rows[e.RowIndex].Cells["Presentacion"].Value.ToString();            
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            if (!(txtBusqueda.Text == ""))
            {
                _en.NombreProducto = txtBusqueda.Text;
                dgInventario.DataSource = _inventarioBl.MostrarInventarioPorNombre(_en);
               
            }

        }

        private void btModificar_Click(object sender, EventArgs e)
        {

            if (txtIdProducto.Text != "" && txtNombreDelProducto.Text != "")
            {
                _en.IdProducto = long.Parse(txtIdProducto.Text);
                _en.NombreProducto = txtNombreDelProducto.Text;
                _en.GrupoPertenenciente = txtGrupoPerteneciente.Text;
                _en.Cantidad = Int32.Parse(txtCantidad.Text);
                _en.Presentacion = cbPresentacion.Text;
                _en.CostoUnitario = decimal.Parse(txtCostoUnitario.Text);
                _en.PrecioContado = decimal.Parse(txtPrecioDeContado.Text);
                _en.PrecioACredito = decimal.Parse(txtPrecioCredito.Text);


                if (_inventarioBl.ModificarProducto(_en) > 0)
                {
                    MessageBox.Show("Se modificó correctamente", "Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    dgInventario.DataSource = _inventarioBl.MostrarInventario();
                    dgInventario.Refresh();

                }

                else
                {
                    MessageBox.Show("Ocurrio un problema, no se pudo modificar", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Seleccione un Registro", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }
    }
}
