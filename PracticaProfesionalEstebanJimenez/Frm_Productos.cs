using PracticaProfesional.Entidades;
using PracticaProfesional.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaProfesionalEstebanJimenez
{
    public partial class Frm_Productos : Form
    {
        public Frm_Productos()
        {
            InitializeComponent();
          
        }
      

        #region "Mis Variables"
        int Codigo_Producto = 0;
        int Codigo_Marca = 0;
        int Codigo_Unidad = 0;
        int Codigo_Categoria = 0;
        int Estadoguarda = 0; //Sin alguna accion

        #endregion




        #region "Mis Metodos"
        private void Formato_pr()
        {
            DgvPrincipal.Columns[0].Width = 90;
            DgvPrincipal.Columns[0].HeaderText = "Código";
            DgvPrincipal.Columns[1].Width = 200;
            DgvPrincipal.Columns[1].HeaderText = "Producto";
            DgvPrincipal.Columns[2].Width = 170;
            DgvPrincipal.Columns[2].HeaderText = "Marca";
            DgvPrincipal.Columns[3].Width = 150;
            DgvPrincipal.Columns[3].HeaderText = "Medida";
            DgvPrincipal.Columns[4].Width = 170;
            DgvPrincipal.Columns[4].HeaderText = "Categoria";
            DgvPrincipal.Columns[5].Width = 90;
            DgvPrincipal.Columns[5].HeaderText = "Stock Min";
            DgvPrincipal.Columns[6].Width = 90;
            DgvPrincipal.Columns[6].HeaderText = "Stock Max";
            DgvPrincipal.Columns[7].Visible = false;
            DgvPrincipal.Columns[8].Visible = false;
            DgvPrincipal.Columns[9].Visible = false;
            DgvPrincipal.Columns[10].Visible = false;

        }

        private void Listado_pr(string cTexto)
        {
            try
            {
                DgvPrincipal.DataSource = N_Productos.Listado_pr(cTexto);
                this.Formato_pr();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Estado_BotonesPrincipales(bool lEstado)
        {
            this.BtnNuevo.Enabled = lEstado;
            this.BtnActualizar.Enabled = lEstado;
            this.BtnEliminar.Enabled = lEstado;
            this.BtnReporte.Enabled = lEstado;
            this.BtnSalir.Enabled = lEstado;

        }

        private void Estado_Botonesprocesos(bool lEstado)
        {
            this.BtnCancelar.Visible = lEstado;
            this.BtnGuardar.Visible = lEstado;
            this.BtnRetornar.Visible = !lEstado;
        }

        private void Selecciona_item()
        {
            if (string.IsNullOrEmpty(Convert.ToString(DgvPrincipal.CurrentRow.Cells["Codigo_Producto"].Value)))
            {
                MessageBox.Show("No se tiene informacion para visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Codigo_Producto = Convert.ToInt32(DgvPrincipal.CurrentRow.Cells["Codigo_Producto"].Value);
                TxtDescripcionProducto.Text = Convert.ToString(DgvPrincipal.CurrentRow.Cells["Descripcion_Producto"].Value);
                this.Codigo_Marca = Convert.ToInt32(DgvPrincipal.CurrentRow.Cells["Codigo_Marca"].Value);
                TxtDescripcionMarca.Text = Convert.ToString(DgvPrincipal.CurrentRow.Cells["Descripcion_Marca"].Value);
                this.Codigo_Unidad = Convert.ToInt32(DgvPrincipal.CurrentRow.Cells["Codigo_Unidad"].Value);
                TxtDescripcionUnidad.Text = Convert.ToString(DgvPrincipal.CurrentRow.Cells["Descripcion_Unidad"].Value);
                this.Codigo_Categoria = Convert.ToInt32(DgvPrincipal.CurrentRow.Cells["Codigo_Categoria"].Value);
                TxtDescripcionCategoria.Text = Convert.ToString(DgvPrincipal.CurrentRow.Cells["Descripcion_Categoria"].Value);
                TxtStock_Min.Text = Convert.ToString(DgvPrincipal.CurrentRow.Cells["Stock_Minimo"].Value);
                TxtStock_Max.Text = Convert.ToString(DgvPrincipal.CurrentRow.Cells["Stock_Maximo"].Value);
                TxtPrecioVenta.Text = Convert.ToString(DgvPrincipal.CurrentRow.Cells["Precio_Venta"].Value);

            }

        }

        private void Formato_ma_pr()
        {
           DgvMarcas.Columns[0].Width = 300;
            DgvMarcas.Columns[0].HeaderText = "Marca";
            DgvMarcas.Columns[1].Visible = false;

        }

        private void Listado_ma_pr(string cTexto)
        {
            try
            {
                DgvMarcas.DataSource = N_Productos.Listado_ma_pr(cTexto);
                this.Formato_ma_pr();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Selecciona_item_ma_pr()
        {
            if (string.IsNullOrEmpty(Convert.ToString(DgvMarcas.CurrentRow.Cells["Codigo_Marca"].Value)))
            {
                MessageBox.Show("No se tiene informacion para visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Codigo_Marca = Convert.ToInt32(DgvMarcas.CurrentRow.Cells["Codigo_Marca"].Value);
                TxtDescripcionMarca.Text = Convert.ToString(DgvMarcas.CurrentRow.Cells["Descripcion_Marca"].Value);
            }

        }


        private void Formato_um_pr()
        {
            DgvMedidas.Columns[0].Width = 300;
            DgvMedidas.Columns[0].HeaderText = "Medidas";
            DgvMedidas.Columns[1].Visible = false;

        }

        private void Listado_um_pr(string cTexto)
        {
            try
            {
                DgvMedidas.DataSource = N_Productos.Listado_um_pr(cTexto);
                this.Formato_um_pr();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Selecciona_um_pr()
        {
            if (string.IsNullOrEmpty(Convert.ToString(DgvMedidas.CurrentRow.Cells["Codigo_Unidad"].Value)))
            {
                MessageBox.Show("No se tiene informacion para visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Codigo_Unidad = Convert.ToInt32(DgvMedidas.CurrentRow.Cells["Codigo_Unidad"].Value);
                TxtDescripcionUnidad.Text = Convert.ToString(DgvMedidas.CurrentRow.Cells["Descripcion"].Value);
            }

        }
        private void Formato_ca_pr()
        {
            DgvCategorias.Columns[0].Width = 300;
            DgvCategorias.Columns[0].HeaderText = "Categorias";
            DgvCategorias.Columns[1].Visible = false;

        }

        private void Listado_ca_pr(string cTexto)
        {
            try
            {
                DgvCategorias.DataSource = N_Productos.Listado_ca_pr(cTexto);
                this.Formato_ca_pr();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Selecciona_item_ca_pr()
        {
            if (string.IsNullOrEmpty(Convert.ToString(DgvCategorias.CurrentRow.Cells["Codigo_Categoria"].Value)))
            {
                MessageBox.Show("No se tiene informacion para visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Codigo_Categoria = Convert.ToInt32(DgvCategorias.CurrentRow.Cells["Codigo_Categoria"].Value);
                TxtDescripcionCategoria.Text = Convert.ToString(DgvCategorias.CurrentRow.Cells["Descripcion"].Value);
            }

        }

        private void Formato_stock_actual()
        {
            DgvStockActual.Columns[0].Width = 200;
            DgvStockActual.Columns[0].HeaderText = "Bodega";
            DgvStockActual.Columns[1].Width = 100;
            DgvStockActual.Columns[1].HeaderText = "Stock Actual";
            DgvStockActual.Columns[2].Width = 100;
            DgvStockActual.Columns[2].HeaderText = "Precio Compra";


        }

        private void Listado_stock_actual(int nCodigo_Producto)
        {
            try
            {
                DgvStockActual.DataSource = N_Productos.Ver_Stock_Actual_Producto(nCodigo_Producto);
                this.Formato_stock_actual();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        #endregion

        private void Frm_Productos_Load(object sender, EventArgs e)
        {
            this.Listado_pr("%");
            this.Listado_um_pr("%");
            this.Listado_ca_pr("%");
            this.Listado_ma_pr("%");    

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtDescripcionProducto.Text == String.Empty ||
                TxtDescripcionMarca.Text == String.Empty ||
                TxtDescripcionUnidad.Text == String.Empty ||
                TxtDescripcionCategoria.Text == String.Empty ||
                TxtPrecioVenta.Text == string.Empty)
                
            {
                MessageBox.Show("Falta ingresar datos requeridos (*)", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else //Se procede a registrar la informacion
            {
                E_Productos oPr = new E_Productos();
                string Rpta = "";
                oPr.Codigo_Producto = this.Codigo_Producto;
                oPr.Descripcion_Producto = TxtDescripcionProducto.Text.Trim();
                oPr.Codigo_Marca = this.Codigo_Marca;
                oPr.Codigo_Unidad = this.Codigo_Unidad;
                oPr.Codigo_Categoria = this.Codigo_Categoria;
                oPr.Stock_min = Convert.ToDecimal(TxtStock_Min.Text);
                oPr.Stock_max = Convert.ToDecimal(TxtStock_Max.Text);
                oPr.Precio_Venta = Convert.ToDecimal(TxtPrecioVenta.Text);

                Rpta = N_Productos.Guadar_pr(Estadoguarda, oPr);
                if (Rpta == "OK")
                {
                    this.Listado_pr("%");
                    MessageBox.Show("Los datos han sido guardados correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Estadoguarda = 0; //Sin ninguna accion
                    this.Estado_BotonesPrincipales(true);
                    this.Estado_Botonesprocesos(false);
                    TxtDescripcionProducto.Text = "";
                    TxtStock_Min.Text = "0";
                    TxtStock_Max.Text = "0";
                    TxtPrecioVenta.Text = "0";
                    TxtDescripcionProducto.ReadOnly = true;
                    TxtStock_Min.ReadOnly = true;
                    TxtStock_Max.ReadOnly = true;
                    TxtPrecioVenta.ReadOnly = true;
                    TbpPrincipal.SelectedIndex = 0;
                    this.Codigo_Producto = 0;
                    GbxDetalle.Visible = false;



                }
                else
                {
                    MessageBox.Show(Rpta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            Estadoguarda = 1; //Nuevo Registro
            GbxDetalle.Visible = false;
            this.Estado_BotonesPrincipales(false);
            this.Estado_Botonesprocesos(true);
            TxtDescripcionProducto.Text = "";
            TxtStock_Min.Text="0";
            TxtStock_Max.Text = "0";
            TxtPrecioVenta.Text = "0";
            TxtDescripcionProducto.ReadOnly = false;
            TxtStock_Min.ReadOnly = false;  
            TxtStock_Max.ReadOnly = false;
            TxtPrecioVenta.ReadOnly = false;
            TbpPrincipal.SelectedIndex = 1;
            TxtDescripcionProducto.Focus();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            Estadoguarda = 2; //Actualizar Registro
            GbxDetalle.Visible = false;
            this.Estado_BotonesPrincipales(false);
            this.Estado_Botonesprocesos(true);
            this.Selecciona_item();
            TbpPrincipal.SelectedIndex = 1;
            TxtDescripcionProducto.ReadOnly = false;
            TxtStock_Min.ReadOnly = false;
            TxtStock_Max.ReadOnly = false;
            TxtPrecioVenta.ReadOnly = false;
            TxtDescripcionProducto.Focus();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Estadoguarda = 0; //Sin ninuguna accion
            GbxDetalle.Visible = false;
            this.Codigo_Marca = 0;
            TxtDescripcionProducto.Text = "";
            TxtStock_Min.Text = "0";
            TxtStock_Max.Text = "0";
            TxtPrecioVenta.Text = "0";
            TxtDescripcionProducto.ReadOnly = true;
            TxtStock_Min.ReadOnly=true;
            TxtStock_Max.ReadOnly = true;
            TxtPrecioVenta.ReadOnly = true;
            this.Estado_BotonesPrincipales(true);
            this.Estado_Botonesprocesos(false);
            TbpPrincipal.SelectedIndex = 0;
        }

        private void DgvPrincipal_DoubleClick(object sender, EventArgs e)
        {
            this.Selecciona_item();
            this.Estado_Botonesprocesos(false);
            TbpPrincipal.SelectedIndex = 1;
            this.Listado_stock_actual(this.Codigo_Producto);
            GbxDetalle.Visible = true;
        }

        private void BtnRetornar_Click(object sender, EventArgs e)
        {
            this.Estado_Botonesprocesos(false);
            TbpPrincipal.SelectedIndex = 0;
            this.Codigo_Producto = 0;
            GbxDetalle.Visible = false;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(DgvPrincipal.CurrentRow.Cells["Codigo_Producto"].Value)))
            {
                MessageBox.Show("No se tiene informacion para visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                DialogResult Opcion;
                Opcion = MessageBox.Show("Estas seguro de eliminar el registro seleccionado?", "Aviso del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Opcion == DialogResult.Yes)
                {

                    string Rpta = "";
                    this.Codigo_Producto = Convert.ToInt32(DgvPrincipal.CurrentRow.Cells["Codigo_Producto"].Value);
                    //Enviar a ejecutar la eliminacion de datos
                    Rpta = N_Productos.Eliminar_pr(this.Codigo_Producto);
                    if (Rpta.Equals("OK"))
                    {
                        this.Listado_pr("%");
                        this.Codigo_Producto = 0;
                        MessageBox.Show("Registro Eliminado", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                }



            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.Listado_pr(TxtBuscar.Text.Trim());
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            Reportes.Frm_Rpt_Productos oRptpr = new Reportes.Frm_Rpt_Productos();
            oRptpr.txt_p1.Text = TxtBuscar.Text;
           oRptpr.ShowDialog();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void DgvPrincipal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



   


    

        private void BtnBuscar2_Click(object sender, EventArgs e)
        {
            this.Listado_um_pr(TxtBuscar2.Text);
        }

  

        private void BtnRetornar2_Click(object sender, EventArgs e)
        {
            PnlMedidas.Visible = false;
        }

        private void DgvMedidas_DoubleClick(object sender, EventArgs e)
        {
            this.Selecciona_um_pr();
            PnlMedidas.Visible = false;
        }

        private void btn_lupa3_Click(object sender, EventArgs e)
        {
            this.PnlCategorias.Location = BtnBuscar2.Location;
            this.PnlCategorias.Visible = true;
        }

        private void DgvCategorias_DoubleClick(object sender, EventArgs e)
        {
            this.Selecciona_item_ca_pr();
            PnlCategorias.Visible = false;
        }

        private void BtnBuscar3_Click(object sender, EventArgs e)
        {
            this.Listado_ca_pr(TxtBuscar3.Text);
        }

        private void BtnRetornar3_Click(object sender, EventArgs e)
        {
            PnlCategorias.Visible = false;
        }

        private void BtnMarca_Click(object sender, EventArgs e)
        {
            this.PnlMarcas.Location = BtnBuscar2.Location;
            this.PnlMarcas.Visible = true;
        }

        private void Btn_lupa2_Click(object sender, EventArgs e)
        {
            this.PnlMedidas.Location = BtnBuscar2.Location;
            this.PnlMedidas.Visible = true;
        }

        private void DgvMarcas_DoubleClick(object sender, EventArgs e)
        {
            this.Selecciona_item_ma_pr();
            PnlMarcas.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Listado_ma_pr(TxtBuscarMarca.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PnlMarcas.Visible = false;
        }
    }
}
