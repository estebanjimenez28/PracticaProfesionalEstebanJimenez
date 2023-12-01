using PracticaProfesional.Entidades;
using PracticaProfesional.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace PracticaProfesionalEstebanJimenez
{
    public partial class Frm_EntradaProductos : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-HMNTIQK1\SQLEXPRESS;Initial Catalog=BD_PracticaProfesional;Integrated Security=True;");
        public Frm_EntradaProductos()
        {
            InitializeComponent();
        }

        //Se declara e inicializa las variables del DataTable
        #region "Mis Variables"
        int Codigo_Entrada = 0;
        int Codigo_Proveedor = 0;
        int Codigo_Almacen = 0;
        int Codigo_Usuario = 0;
        int Estadoguarda = 0;
        DataTable TablaDetalle = new DataTable();
        #endregion

        #region "Mis Métodos"
        //Este metodo se crea para aplicar un formato expecifico sobre
        //la informacion que debe llevar el DataGridview Principal.
        private void Formato_ep()
        {
            Dgv_principal.Columns[0].Width = 150;
            Dgv_principal.Columns[0].HeaderText = "CÓDIGO";
            Dgv_principal.Columns[1].Width = 150;
            Dgv_principal.Columns[1].HeaderText = "FACTURA";
            Dgv_principal.Columns[2].Width = 150;
            Dgv_principal.Columns[2].HeaderText = "FECHA";
            Dgv_principal.Columns[3].Width = 200;
            Dgv_principal.Columns[3].HeaderText = "ENCARGADO";
            Dgv_principal.Columns[4].Width = 250;
            Dgv_principal.Columns[4].HeaderText = "ALMACEN";
            Dgv_principal.Columns[5].Width = 250;
            Dgv_principal.Columns[5].HeaderText = "PROVEEDOR";
            Dgv_principal.Columns[6].Width = 140;
            Dgv_principal.Columns[6].HeaderText = "TOTAL";

            //Se procede a ocultar datos que no se desea que se presenten en el DataGridview
            Dgv_principal.Columns[7].Visible = false;
            Dgv_principal.Columns[8].Visible = false;
            Dgv_principal.Columns[9].Visible = false;
            Dgv_principal.Columns[10].Visible = false;
            Dgv_principal.Columns[11].Visible = false;
            Dgv_principal.Columns[12].Visible = false;

        }

        private void Listado_ep(string cTexto)
        {
            //Este metodo se crea para cargar y mostrar los datos en el DataGridview
            try
            {
                Dgv_principal.DataSource = N_EntradaProductos.Listado_Entrada(cTexto);
                this.Formato_ep();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        //Se procede a habilitar los botones en la Interfaz Grafica
        private void Estado_Botonesprincipales(bool lEstado)
        {
            this.BtnNuevo.Enabled = lEstado;
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

            this.BtnAgregar.Visible = lEstado;
            this.BtnDeshacer.Visible = lEstado;

            this.Btn_lupa1.Visible = lEstado;
        }

        private void Selecciona_item()
        {
            //Este método se utiliza para seleccionar un elemento en el DataGridView (Dgv_principal)
            //y mostrar la información asociada en los textBox correspondientes de la interfaz de usuario
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_principal.CurrentRow.Cells["Codigo_Entrada"].Value)))
            {
                MessageBox.Show("No se tiene información para Visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Codigo_Entrada = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["Codigo_Entrada"].Value);
                this.Codigo_Proveedor = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["Codigo_Proveedor"].Value);
                this.Codigo_Almacen = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["Codigo_Almacen"].Value);
                this.Codigo_Usuario = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["Codigo_Usuario"].Value);
                TxtNumeroDocumento.Text = Dgv_principal.CurrentRow.Cells["NumeroDocumento"].Value.ToString();
                Dtp_fecha.Value = Convert.ToDateTime(Dgv_principal.CurrentRow.Cells["Fecha_Entrada"].Value);
                TxtProveedor.Text = Dgv_principal.CurrentRow.Cells["Razon_Social"].Value.ToString();
                CbxUsuario.Text = Dgv_principal.CurrentRow.Cells["NombreCompleto"].Value.ToString();
                Cbx_Almacen.Text = Dgv_principal.CurrentRow.Cells["Descripcion"].Value.ToString();
                TxtObservacion.Text = Dgv_principal.CurrentRow.Cells["Observacion"].Value.ToString();
                TxtIva.Text = Dgv_principal.CurrentRow.Cells["Iva"].Value.ToString();
                TxtSubTotal.Text = Dgv_principal.CurrentRow.Cells["Subtotal"].Value.ToString();
                TxtTotal.Text = Dgv_principal.CurrentRow.Cells["Total"].Value.ToString();

                Dgv_Detalle.DataSource = N_EntradaProductos.Listado_detalle_Entrada(this.Codigo_Entrada);
                this.Formato_detalle();
            }

        }

        private void Crear_TablaDetalle()
        {
            //Se procede a inicializar una tabla de datos "DataTable"
            this.TablaDetalle = new DataTable("TablaDetalle");
            this.TablaDetalle.Columns.Add("Descripcion_Producto", System.Type.GetType("System.String"));
            this.TablaDetalle.Columns.Add("Descripcion_Marca", System.Type.GetType("System.String"));
            this.TablaDetalle.Columns.Add("Descripcion_Unidad", System.Type.GetType("System.String"));
            this.TablaDetalle.Columns.Add("Cantidad", System.Type.GetType("System.Decimal"));
            this.TablaDetalle.Columns.Add("PrecioUnitario", System.Type.GetType("System.Decimal"));
            this.TablaDetalle.Columns.Add("Total", System.Type.GetType("System.Decimal"));
            this.TablaDetalle.Columns.Add("Codigo_Producto", System.Type.GetType("System.Int32"));
            this.TablaDetalle.AcceptChanges();

            Dgv_Detalle.DataSource = this.TablaDetalle;
            this.Formato_detalle();

        }


        //Se define un método llamado Agregar_item que se encarga
        //de agregar un nuevo elemento (fila) a una tabla de datos (TablaDetalle).
        private void Agregar_item(string cDescripcion_pr,
                                  string cDescripcion_ma,
                                  string cDescripcion_um,
                                  decimal nCantidad,
                                  decimal nPu_compra,
                                  decimal nTotal,
                                  int nCodigo_pr)
        {
            DataRow xFila = TablaDetalle.NewRow();
            xFila["Descripcion_Producto"] = cDescripcion_pr;
            xFila["Descripcion_Marca"] = cDescripcion_ma;
            xFila["Descripcion_Unidad"] = cDescripcion_um;
            xFila["Cantidad"] = nCantidad;
            xFila["PrecioUnitario"] = nPu_compra;
            xFila["Total"] = nTotal;
            xFila["Codigo_Producto"] = nCodigo_pr;
            this.TablaDetalle.Rows.Add(xFila);
            TablaDetalle.AcceptChanges();
        }

        private void Formato_detalle()
        {
            //Se define las variables que se colocaran en el datagridview de la tabla de detalle
            Dgv_Detalle.Columns[0].Width = 300;
            Dgv_Detalle.Columns[0].HeaderText = "PRODUCTO";
            Dgv_Detalle.Columns[1].Width = 300;
            Dgv_Detalle.Columns[1].HeaderText = "MARCA";
            Dgv_Detalle.Columns[2].Width = 100;
            Dgv_Detalle.Columns[2].HeaderText = "U.MEDIDA";
            Dgv_Detalle.Columns[3].Width = 100;
            Dgv_Detalle.Columns[3].HeaderText = "CANTIDAD";
            Dgv_Detalle.Columns[4].Width = 190;
            Dgv_Detalle.Columns[4].HeaderText = "PRECIO UNITARIO";
            Dgv_Detalle.Columns[5].Width = 130;
            Dgv_Detalle.Columns[5].HeaderText = "TOTAL";
            Dgv_Detalle.Columns[6].Visible = false;
            Dgv_Detalle.Columns[0].ReadOnly = true;
            Dgv_Detalle.Columns[1].ReadOnly = true;
            Dgv_Detalle.Columns[2].ReadOnly = true;
            Dgv_Detalle.Columns[3].ReadOnly = true;
            Dgv_Detalle.Columns[4].ReadOnly = true;
            Dgv_Detalle.Columns[5].ReadOnly = true;
        }

       


     

        private void Formato_pv()
        {
            //Se aplica un formato al datagridview de proveedores
            DgvProveedores.Columns[0].Width = 320;
            DgvProveedores.Columns[0].HeaderText = "NOMBRE";
            DgvProveedores.Columns[1].Width = 320;
            DgvProveedores.Columns[1].HeaderText = "APELLIDOS.";
            DgvProveedores.Columns[2].Width = 220;
            DgvProveedores.Columns[2].HeaderText = "RAZON SOCIAL.";
            DgvProveedores.Columns[3].Visible = false;

        }

        private void Listado_pv(string cTexto)
        {
            //Se procede a cargar y listar la informacion en el datagridview
            try
            {
                DgvProveedores.DataSource = N_EntradaProductos.Listado_pv_tm(cTexto);
                this.Formato_pv();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Selecciona_pv()
        {
            //Este metodo funcina para seleccionar la informacion del datagriview y mostrarla en los textbox correspondientes
            if (string.IsNullOrEmpty(Convert.ToString(DgvProveedores.CurrentRow.Cells["Codigo_Proveedor"].Value)))
            {
                MessageBox.Show("No se tiene información para Visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Codigo_Proveedor = Convert.ToInt32(DgvProveedores.CurrentRow.Cells["Codigo_Proveedor"].Value);
                TxtProveedor.Text = Convert.ToString(DgvProveedores.CurrentRow.Cells["Razon_Social"].Value);
            }
        }


        public void cargar_datosAlmacen()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Codigo_Almacen,Descripcion FROM Almacenes", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();


            Cbx_Almacen.ValueMember = "Codigo_Almacen";
            Cbx_Almacen.DisplayMember = "Descripcion";
            Cbx_Almacen.DataSource = dt;

        }

        public void cargar_datosUsuario()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Codigo_Usuario,NombreCompleto FROM Usuarios", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            CbxUsuario.ValueMember = "Codigo_Usuario";
            CbxUsuario.DisplayMember = "NombreCompleto";
            CbxUsuario.DataSource = dt;

        }




        private void Formato_pr()
        {
            //Se aplica un formato al datagridview de productos
            DgvProductos.Columns[0].Width = 250;
            DgvProductos.Columns[0].HeaderText = "PRODUCTO";
            DgvProductos.Columns[1].Width = 250;
            DgvProductos.Columns[1].HeaderText = "MARCA.";
            DgvProductos.Columns[2].Width = 140;
            DgvProductos.Columns[2].HeaderText = "U.MEDIDA";
            DgvProductos.Columns[3].Width = 230;
            DgvProductos.Columns[3].HeaderText = "CATEGORÍA";
            DgvProductos.Columns[4].Visible = false;

        }

        private void Listado_pr(string cTexto)
        {
            //Se procede a cargar y listar la informacion en el datagridview
            try
            {
                DgvProductos.DataSource = N_EntradaProductos.Listado_pr_tm(cTexto);
                this.Formato_pr();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Selecciona_pr()
        {
            //Este metodo funcina para seleccionar la informacion del datagriview y mostrarla en los textbox correspondientes
            if (string.IsNullOrEmpty(Convert.ToString(DgvProductos.CurrentRow.Cells["Codigo_Producto"].Value)))
            {
                MessageBox.Show("No se tiene información para Visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                string xDescripcion_pr;
                string xDescripcion_ma;
                string xDescripcion_um;
                decimal xCantidad;
                decimal xPu_compra;
                decimal xTotal;
                int xCodigo_pr;

                bool Agregar = true;


                //Se utiliza un bucle foreach para verificar si el producto ya está en la tabla de detalle (TablaDetalle). Si el producto ya está presente,
                //se establece el Agregar en falso y se muestra un mensaje de advertencia.

                xCodigo_pr = Convert.ToInt32(DgvProductos.CurrentRow.Cells["Codigo_Producto"].Value);
                foreach (DataRow Filatemp in TablaDetalle.Rows)
                {
                    if (Convert.ToInt32(Filatemp["Codigo_Producto"]) == xCodigo_pr)
                    {
                        Agregar = false;
                        MessageBox.Show("El producto ya se encuetra agregado", "Aviso del Sistema");
                    }
                }

                //Si el Agregar sigue siendo verdadera, se agrega la información del producto a la tabla de
                //detalle llamando al método Agregar_item. Este método se encarga de agregar una nueva fila
                //con la información del producto a la tabla de detalle.

                if (Agregar == true)
                {
                    xDescripcion_pr = Convert.ToString(DgvProductos.CurrentRow.Cells["Descripcion_Producto"].Value);
                    xDescripcion_ma = Convert.ToString(DgvProductos.CurrentRow.Cells["Descripcion_Marca"].Value);
                    xDescripcion_um = Convert.ToString(DgvProductos.CurrentRow.Cells["Descripcion"].Value);
                    xCantidad = Convert.ToDecimal("0.00");
                    xPu_compra = Convert.ToDecimal("0.00");
                    xTotal = Convert.ToDecimal("0.00");


                    this.Agregar_item(xDescripcion_pr,
                                      xDescripcion_ma,
                                      xDescripcion_um,
                                      xCantidad,
                                      xPu_compra,
                                      xTotal,
                                      xCodigo_pr);
                }

            }
        }
        private void Estado_texto(bool lestado)
        {
            //Este metodo se encarga de cambiar el estado de lectura (read-only) de varios controles TextBox
            TxtNumeroDocumento.ReadOnly = !lestado;
            TxtObservacion.ReadOnly = !lestado;
            Dtp_fecha.Enabled = lestado;
        }

        private void Limpia_texto()
        {
            //Este metodo se encargara de limpiar el contenido de varios controles TextBox
            TxtNumeroDocumento.Text = "";
            TxtObservacion.Text = "";
            TxtSubTotal.Text = "";
            TxtIva.Text = "";
            TxtTotal.Text = "";
            this.Crear_TablaDetalle();
        }

        private void Calcular_totales()
        {
            //Este metodo se encargara de calcular y actualizar los totales (subtotal, IVA y total)
            //en base a la información almacenada en una tabla de detalle 

            decimal nSubtotal = 0;
            decimal nIgv = 0;
            decimal nTotal_importe = 0;
            if (Dgv_Detalle.Rows.Count == 0)
            {
                nSubtotal = 0;
                nIgv = 0;
                nTotal_importe = 0;
            }
            else
            {
                TablaDetalle.AcceptChanges();
                foreach (DataRow Filatemp in TablaDetalle.Rows)
                {
                    nTotal_importe = nTotal_importe + Convert.ToDecimal(Filatemp["Total"]);
                }

                nSubtotal = nTotal_importe / (1 + Convert.ToDecimal("0.13"));
                nIgv = (nTotal_importe - nSubtotal);

                TxtIva.Text = decimal.Round(nIgv, 2).ToString("#0.00");

                TxtSubTotal.Text = decimal.Round(nSubtotal, 2).ToString("#0.00");
                TxtTotal.Text = decimal.Round(nTotal_importe, 2).ToString("#0.00");
            }

        }
        #endregion

        private void Frm_EntradaProductos_Load(object sender, EventArgs e)
        {
            //Se carga la informacion en los formularios
            this.Listado_ep("%");
            this.Listado_pv("%");
            this.cargar_datosAlmacen();
            this.cargar_datosUsuario(); 
    
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (
                TxtNumeroDocumento.Text == string.Empty ||
                TxtProveedor.Text == String.Empty ||
                Dgv_Detalle.Rows.Count == 0)
            {
                MessageBox.Show("Falta ingresa datos requeridos (*)", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else //Se procede a registrar la información
            {
                string NumeroDocumento = TxtNumeroDocumento.Text.Trim();
                bool agregar = true; // Asumimos que inicialmente está bien agregar el producto.

                foreach (DataGridViewRow fila in Dgv_principal.Rows)
                {
                    if (fila.Cells["NumeroDocumento"].Value != null &&
                        fila.Cells["NumeroDocumento"].Value.ToString().Trim().Equals(NumeroDocumento, StringComparison.OrdinalIgnoreCase))
                    {
                        agregar = false;
                        MessageBox.Show("La compra con este numero de factura ya se encuentra agregada en el sistema", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break; // No es necesario seguir verificando si ya se encontró una coincidencia.
                    }
                }
                if (agregar)
                {
                    // Si agregar es true, significa que no se encontró una coincidencia en el DataGridView,
                    // por lo que procedemos a registrar el producto.

                    string Rpta = "";
                    E_EntradaProductos oEp = new E_EntradaProductos();


                    // Obtener el valor seleccionado del ComboBox y asignarlo al objeto oCl
                    if (Cbx_Almacen.SelectedItem != null)
                    {
                        // Aquí asumimos que la propiedad "Value" del ComboBox contiene el código del tipo de identificación.
                        oEp.Codigo_Almacen = Convert.ToInt32(Cbx_Almacen.SelectedValue);
                    }

                    // Obtener el valor seleccionado del ComboBox y asignarlo al objeto oCl
                    if (CbxUsuario.SelectedItem != null)
                    {
                        // Aquí asumimos que la propiedad "Value" del ComboBox contiene el código del tipo de identificación.
                        oEp.Codigo_Usuario = Convert.ToInt32(CbxUsuario.SelectedValue);
                    }

                    oEp.Codigo_Entrada = this.Codigo_Entrada;
                    oEp.NumeroDocumento = TxtNumeroDocumento.Text.Trim();
                    oEp.Fecha = Dtp_fecha.Value;
                    oEp.Codigo_Proveedor = this.Codigo_Proveedor;
                    oEp.Observacion = TxtObservacion.Text.Trim();
                    oEp.Subtotal = Convert.ToDecimal(TxtSubTotal.Text.Trim());
                    oEp.Iva = Convert.ToDecimal(TxtIva.Text.Trim());
                    oEp.Total = Convert.ToDecimal(TxtTotal.Text.Trim());

                    this.TablaDetalle.AcceptChanges();

                    Rpta = N_EntradaProductos.Guadar_Entrada(oEp, TablaDetalle);
                    if (Rpta.Equals("OK"))
                    {
                        this.Listado_ep("%");
                        MessageBox.Show("La compra se ha guardado correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Estado_Botonesprincipales(true);
                        this.Estado_Botonesprocesos(false);
                        this.Estado_texto(false);
                        Dgv_Detalle.Columns[3].ReadOnly = true;
                        Dgv_Detalle.Columns[4].ReadOnly = true;

                        TbpPrincipal.SelectedIndex = 0;
                        this.Codigo_Entrada = 0;
                        this.Estadoguarda = 0;

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
            //Se establece el estado de guardado en 1, indicando que se está creando un nuevo registro.
            this.Estadoguarda = 1;
            //Desactiva los botones principales.
            this.Estado_Botonesprincipales(false);
           // Activa los botones de procesos.
            this.Estado_Botonesprocesos(true);
            this.Limpia_texto();
            // Se habilita la edición en la columna 3 del DataGridView de detalle.
            Dgv_Detalle.Columns[3].ReadOnly = false;
            // Habilita la edición en la columna 4 del DataGridView de detalle.
            Dgv_Detalle.Columns[4].ReadOnly = false;
            this.Estado_texto(true);
            //Se procede a cambiar a la segunda pestaña en un control TabControl llamado TbpPrincipal
            TbpPrincipal.SelectedIndex = 1;
            TxtNumeroDocumento.Focus();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            // Se restablece el código a cero.
            this.Codigo_Entrada = 0;
            this.Codigo_Usuario = 0;
            this.Codigo_Proveedor = 0;
            this.Codigo_Almacen = 0;
            this.Estadoguarda = 0;

            this.Estado_texto(false);
            this.Limpia_texto();
            Dgv_Detalle.Columns[3].ReadOnly = true;
            Dgv_Detalle.Columns[4].ReadOnly = true;

            this.Estado_Botonesprincipales(true);
            this.Estado_Botonesprocesos(false);
            TbpPrincipal.SelectedIndex = 0;
        }

        private void Dgv_principal_DoubleClick(object sender, EventArgs e)
        {
            //Al seleccionar 2 veces la informacion en el Dgv esta se mostrara en el textBox Correspondiente
            this.Selecciona_item();
            this.Estado_Botonesprocesos(false);
            TbpPrincipal.SelectedIndex = 1;
        }

        private void BtnRetornar_Click(object sender, EventArgs e)
        {
            //Se cambia de la primera pestaña en un control TabControl llamado TbpPrincipal
            this.Estado_Botonesprocesos(false);
            TbpPrincipal.SelectedIndex = 0;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            //Este código está diseñado para permitir al usuario eliminar (anular) un registro de entrada.
            //Realiza la eliminación en la capa de negocio y actualiza la interfaz de usuario
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_principal.CurrentRow.Cells["Codigo_Entrada"].Value)))
            {
                MessageBox.Show("No se tiene información para Visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Estás seguro de anular el registro seleccionado?", "Aviso del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Opcion == DialogResult.Yes)
                {
                    string Rpta = "";
                    this.Codigo_Entrada = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["Codigo_Entrada"].Value);
                    Rpta =N_EntradaProductos.Eliminar_Entrada(this.Codigo_Entrada);
                    if (Rpta.Equals("OK"))
                    {
                        this.Listado_ep("%");
                        this.Codigo_Entrada = 0;
                        MessageBox.Show("Registro Anulado", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }



            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            //Se filtra la informacion del dataGridview Principal
            this.Listado_ep(TxtBuscar.Text.Trim());
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            //Se crea una instancia del formulario de reporte

            Reportes.Frm_Rpt_Entrada_Productos oRpt_ep = new Reportes.Frm_Rpt_Entrada_Productos();
            oRpt_ep.txt_p1.Text = TxtBuscar.Text;
            oRpt_ep.ShowDialog();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            //se cierra el formulario
            this.Close();
        }

        private void Btn_lupa1_Click(object sender, EventArgs e)
        {
            //Se despliega la ventana de Proveedor
            this.PnlProveedor.Location = Dtp_fecha.Location;
            this.PnlProveedor.Visible = true;
        }

     

      

        private void DgvProductos_DoubleClick(object sender, EventArgs e)
        {
            //Al dar doble clik la informacion se muestra en el textBox
            this.Selecciona_pr();
            PnlProducto.Visible = false;
        }

        private void Dgv_Detalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Se actualiza  la columna "Total" en la tabla de detalle del DataGridView cuando el usuario hace clic en una celda. Este comportamiento puede ser útil
            //para calcular automáticamente el total en función de la cantidad y el precio unitario al editar una fila.
            if (this.Estadoguarda == 1)
            {
                DataRow yFila = (DataRow)TablaDetalle.Rows[e.RowIndex];
                decimal yCantidad = Convert.ToDecimal(yFila["Cantidad"]);
                decimal yPu_compra = Convert.ToDecimal(yFila["PrecioUnitario"]);
                yFila["Total"] = decimal.Round(yCantidad * yPu_compra, 2).ToString("#0.00");

                this.Calcular_totales();
            }
        }

      

        private void BtnBuscar5_Click(object sender, EventArgs e)
        {
            this.Listado_pr(TxtBuscar5.Text);
        }

        private void BtnRetornar5_Click(object sender, EventArgs e)
        {
            //Se oculta el formulario de Productos
            PnlProducto.Visible = false;
        }

        private void BtnAgregar_Click_1(object sender, EventArgs e)
        {
            //Se despliega el formulario de Lista de Productos
            PnlProducto.Location = TxtObservacion.Location;
            PnlProducto.Visible = true;
            TxtBuscar5.Focus();
        }

        private void BtnDeshacer_Click_1(object sender, EventArgs e)
        {
            //Se busca proporcionar una funcionalidad para deshacer la última acción realizada en el DataGridView de detalle.
            if (Dgv_Detalle.Rows.Count > 0)
            {
                Dgv_Detalle.Rows.Remove(Dgv_Detalle.CurrentRow);
                Dgv_Detalle.Refresh();
                TablaDetalle.AcceptChanges();
                this.Calcular_totales();
            }
        }


        private void DgvProveedores_DoubleClick_1(object sender, EventArgs e)
        {
            //Al dar doble clik la informacion se muestra en el textBox
            this.Selecciona_pv();
            PnlProveedor.Visible = false;
        }

        private void BtnBuscar3_Click_1(object sender, EventArgs e)
        {
            //se filtra la informacion de los proveedores
            this.Listado_pv(TxtBuscar3.Text);
        }

        private void BtnRetornar3_Click_1(object sender, EventArgs e)
        {
            //Se devuelve al formulario principal
            PnlProveedor.Visible = false;
        }

        private void TxtNumeroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, true);
        }

        private void TxtObservacion_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = Validaciones.CaracteresTexto(e, true);
        }
    }
}
