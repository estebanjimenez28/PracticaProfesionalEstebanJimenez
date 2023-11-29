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
        //Se declara e inicializa las variables del DataTable
        int Codigo_Producto = 0;
        int Codigo_Marca = 0;
        int Codigo_Unidad = 0;
        int Codigo_Categoria = 0;
        int Estadoguarda = 0; //Sin alguna accion

        #endregion




        #region "Mis Metodos"
        private void Formato_pr()
        {
            //Este metodo se crea para aplicar un formato expecifico sobre
            //la informacion que debe llevar el DataGridview Principal.
            DgvPrincipal.Columns[0].Width = 100;
            DgvPrincipal.Columns[0].HeaderText = "CÓDIGO";
            DgvPrincipal.Columns[1].Width = 250;
            DgvPrincipal.Columns[1].HeaderText = "PRODUCTO";
            DgvPrincipal.Columns[2].Width = 210;
            DgvPrincipal.Columns[2].HeaderText = "MARCA";
            DgvPrincipal.Columns[3].Width = 220;
            DgvPrincipal.Columns[3].HeaderText = "MEDIDA";
            DgvPrincipal.Columns[4].Width = 200;
            DgvPrincipal.Columns[4].HeaderText = "CATEGORIA";
            DgvPrincipal.Columns[5].Width = 120;
            DgvPrincipal.Columns[5].HeaderText = "STOCK MIN";
            DgvPrincipal.Columns[6].Width = 120;
            DgvPrincipal.Columns[6].HeaderText = "STOCK MAX";
            DgvPrincipal.Columns[7].Width = 150;
            DgvPrincipal.Columns[7].HeaderText = "P.VENTA";

            //Se procede a ocultar datos que no se desea que se presenten en el DataGridview
            DgvPrincipal.Columns[8].Visible = false;
            DgvPrincipal.Columns[9].Visible = false;
            DgvPrincipal.Columns[10].Visible = false;
            

        }

        private void Listado_pr(string cTexto)
        {
            //Este metodo se crea para cargar y mostrar los datos en el DataGridview
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
            //Se procede a habilitar los botones en la Interfaz Grafica
            this.BtnNuevo.Enabled = lEstado;
            this.BtnActualizar.Enabled = lEstado;
            this.BtnEliminar.Enabled = lEstado;
            this.BtnReporte.Enabled = lEstado;
            this.BtnSalir.Enabled = lEstado;

        }

        private void Estado_Botonesprocesos(bool lEstado)
        {
            //Este proceso nos ayuda a controlar la visibilidad de los botones en un momento determinado
            this.BtnCancelar.Visible = lEstado;
            this.BtnGuardar.Visible = lEstado;
            this.BtnRetornar.Visible = !lEstado;
        }

        private void Selecciona_item()
        {
            //Este método se utiliza para seleccionar un elemento en el DataGridView (Dgv_principal)
            //y mostrar la información asociada en los textBox correspondientes de la interfaz de usuario
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
            //Se aplica un formato al datagridview de Marcas
            DgvMarcas.Columns[0].Width = 650;
            DgvMarcas.Columns[0].HeaderText = "Seleccione una Opción";
            DgvMarcas.Columns[1].Visible = false;

        }

        private void Listado_ma_pr(string cTexto)
        {
            //Se procede a cargar y listar la informacion en el datagridview
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
            //Este metodo funcina para seleccionar la informacion del datagriview y mostrarla en los textbox correspondientes
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
            //Se aplica un formato al datagridview de Unidad de Medida
            DgvMedidas.Columns[0].Width = 600;
            DgvMedidas.Columns[0].HeaderText = "Seleccione una Opción";
            DgvMedidas.Columns[1].Visible = false;

        }

        private void Listado_um_pr(string cTexto)
        {
            //Se procede a cargar y listar la informacion en el datagridview
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
            //Este metodo funcina para seleccionar la informacion del datagriview y mostrarla en los textbox correspondientes
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
            //Se aplica un formato al datagridview de Unidad de Categoria
            DgvCategorias.Columns[0].Width = 650;
            DgvCategorias.Columns[0].HeaderText = "Seleccione una Opción";
            DgvCategorias.Columns[1].Visible = false;

        }

        private void Listado_ca_pr(string cTexto)
        {
            //Se procede a cargar y listar la informacion en el datagridview
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
            //Este metodo funcina para seleccionar la informacion del datagriview y mostrarla en los textbox correspondientes
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
            //Se aplica un formato al datagridview de Stock Actual
            DgvStockActual.Columns[0].Width = 240;
            DgvStockActual.Columns[0].HeaderText = "BODEGA";
            DgvStockActual.Columns[1].Width = 240;
            DgvStockActual.Columns[1].HeaderText = "STOCK ACTUAL";
            DgvStockActual.Columns[2].Width = 240;
            DgvStockActual.Columns[2].HeaderText = "PRECIO COMPRA";


        }

        private void Listado_stock_actual(int nCodigo_Producto)
        {
            //Se procede a cargar y listar la informacion en el datagridview
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
            //Se carga la informacion en los formularios
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
            else // Se procede a registrar la información
            {
                string nombreProducto = TxtDescripcionProducto.Text.Trim();
                bool agregar = true; // Asumimos que inicialmente está bien agregar el producto.

                foreach (DataGridViewRow fila in DgvPrincipal.Rows)
                {
                    if (fila.Cells["Descripcion_Producto"].Value != null &&
                        fila.Cells["Descripcion_Producto"].Value.ToString().Trim().Equals(nombreProducto, StringComparison.OrdinalIgnoreCase))
                    {
                        agregar = false;
                        MessageBox.Show("El producto ya se encuentra agregado en el sistema", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break; // No es necesario seguir verificando si ya se encontró una coincidencia.
                    }
                }

                if (agregar)
                {
                    // Si agregar es true, significa que no se encontró una coincidencia en el DataGridView,
                    // por lo que procedemos a registrar el producto.

                    E_Productos oPr = new E_Productos();
                    string Rpta = "";
                    oPr.Codigo_Producto = this.Codigo_Producto;
                    oPr.Descripcion_Producto = nombreProducto; // Utilizamos la variable nombreProducto
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

                        Estadoguarda = 0; // Sin ninguna acción
                        this.Estado_BotonesPrincipales(true);
                        this.Estado_Botonesprocesos(false);
                        TxtDescripcionProducto.Text = "";
                        TxtStock_Min.Text = "0";
                        TxtStock_Max.Text = "0";
                        TxtPrecioVenta.Text = "0";
                        TxtDescripcionProducto.ReadOnly = false;
                        TxtStock_Min.ReadOnly = false;
                        TxtStock_Max.ReadOnly = false;
                        TxtPrecioVenta.ReadOnly = false;
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
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            //Se establece el estado de guardado en 1, indicando que se está creando un nuevo registro
            Estadoguarda = 1; //Nuevo Registro
            GbxDetalle.Visible = false;
            //Desactiva los botones principales.
            this.Estado_BotonesPrincipales(false);
            // Activa los botones de procesos.
            this.Estado_Botonesprocesos(true);
            TxtDescripcionProducto.Text = "";
            TxtStock_Min.Text="0";
            TxtStock_Max.Text = "0";
            TxtPrecioVenta.Text = "0";
            TbpPrincipal.SelectedIndex = 1;
            TxtDescripcionProducto.Focus();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (TxtDescripcionProducto.Text == String.Empty ||
          TxtDescripcionMarca.Text == String.Empty ||
          TxtDescripcionUnidad.Text == String.Empty ||
          TxtDescripcionCategoria.Text == String.Empty ||
          TxtPrecioVenta.Text == string.Empty)
            {
                MessageBox.Show("Falta ingresar datos requeridos (*)", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else // Se procede a modificar la información
            {
                string nombreProducto = TxtDescripcionProducto.Text.Trim();
                bool modificar = false; // Asumimos que inicialmente no está permitido modificar el producto.

                foreach (DataGridViewRow fila in DgvPrincipal.Rows)
                {
                    if (fila.Cells["Descripcion_Producto"].Value != null &&
                        fila.Cells["Descripcion_Producto"].Value.ToString().Trim().Equals(nombreProducto, StringComparison.OrdinalIgnoreCase))
                    {
                        modificar = true;
                        break; // No es necesario seguir verificando si ya se encontró una coincidencia.
                    }
                }

                if (modificar)
                {
                    // Si modificar es true, significa que se encontró una coincidencia en el DataGridView,
                    // por lo que procedemos a modificar el producto.

                    E_Productos oPr = new E_Productos();
                    string Rpta = "";
                    oPr.Codigo_Producto = this.Codigo_Producto; // Debes tener el código del producto que deseas modificar.
                    oPr.Descripcion_Producto = nombreProducto;
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
                        MessageBox.Show("Los datos han sido modificados correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Estadoguarda = 0; // Sin ninguna acción
                        this.Estado_BotonesPrincipales(true);
                        this.Estado_Botonesprocesos(false);
                        TxtDescripcionProducto.Text = "";
                        TxtStock_Min.Text = "0";
                        TxtStock_Max.Text = "0";
                        TxtPrecioVenta.Text = "0";
                        TxtDescripcionProducto.ReadOnly = false;
                        TxtStock_Min.ReadOnly = false;
                        TxtStock_Max.ReadOnly = false;
                        TxtPrecioVenta.ReadOnly = false;
                        TbpPrincipal.SelectedIndex = 0;
                        this.Codigo_Producto = 0;
                        GbxDetalle.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show(Rpta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El producto no se encuentra en el sistema. No es posible modificar.", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            // Se restablece el código a cero.
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
            //Al seleccionar 2 veces la informacion en el Dgv esta se mostrara en el textBox Correspondiente
            this.Selecciona_item();
            this.Estado_Botonesprocesos(false);
            TbpPrincipal.SelectedIndex = 1;
            this.Listado_stock_actual(this.Codigo_Producto);
            GbxDetalle.Visible = true;
        }

        private void BtnRetornar_Click(object sender, EventArgs e)
        {
            //Regresa al formulario principal
            this.Estado_Botonesprocesos(false);
            TbpPrincipal.SelectedIndex = 0;
            this.Codigo_Producto = 0;
            GbxDetalle.Visible = false;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            //Este código está diseñado para permitir al usuario eliminar (anular) un registro de entrada.
            //Realiza la eliminación en la capa de negocio y actualiza la interfaz de usuario
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
            //Se filtra la informacion del dataGridview Principal
            this.Listado_pr(TxtBuscar.Text.Trim());
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            //Se crea una instancia del formulario de reporte
            Reportes.Frm_Rpt_Productos oRptpr = new Reportes.Frm_Rpt_Productos();
            oRptpr.txt_p1.Text = TxtBuscar.Text;
           oRptpr.ShowDialog();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            //Se cierra el formulario
            this.Close();
        }

        private void BtnBuscar2_Click(object sender, EventArgs e)
        {
            //Se filtra la informacion del dataGridview Unidad Medida
            this.Listado_um_pr(TxtBuscar2.Text);
        }

  

        private void BtnRetornar2_Click(object sender, EventArgs e)
        {
            //Se oculta el formulario de Unidad Medida
            PnlMedidas.Visible = false;
        }

        private void DgvMedidas_DoubleClick(object sender, EventArgs e)
        {
            //Al dar doble clik la informacion se muestra en el textBox
            this.Selecciona_um_pr();
            PnlMedidas.Visible = false;
        }

        private void btn_lupa3_Click(object sender, EventArgs e)
        {
            //Se despliega el formulario de Categorias
            this.PnlCategorias.Location = BtnMarca.Location;
            this.PnlCategorias.Visible = true;
        }

        private void DgvCategorias_DoubleClick(object sender, EventArgs e)
        {
            //Al dar doble clik la informacion se muestra en el textBox
            this.Selecciona_item_ca_pr();
            PnlCategorias.Visible = false;
        }

        private void BtnBuscar3_Click(object sender, EventArgs e)
        {
            //Se filtra la informacion del dataGridview Categorias
            this.Listado_ca_pr(TxtBuscar3.Text);
        }

        private void BtnRetornar3_Click(object sender, EventArgs e)
        {
            //Se oculta el formulario de Categorias
            PnlCategorias.Visible = false;
        }

        private void BtnMarca_Click(object sender, EventArgs e)
        {
            this.PnlMarcas.Location = BtnMarca.Location;
            this.PnlMarcas.Visible = true;
        }

        private void Btn_lupa2_Click(object sender, EventArgs e)
        {
            //Se despliega el formulario de Unidad Medida
            this.PnlMedidas.Location = BtnMarca.Location;
            this.PnlMedidas.Visible = true;
        }

        private void DgvMarcas_DoubleClick(object sender, EventArgs e)
        {
            this.Selecciona_item_ma_pr();
            PnlMarcas.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Se filtra la informacion del dataGridview Marcas
            this.Listado_ma_pr(TxtBuscarMarca.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Se oculta el formulario de Marcas
            PnlMarcas.Visible = false;
        }

        private void TxtDescripcionProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, true);
        }
    }
}
