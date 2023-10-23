using PracticaProfesional.Entidades;
using PracticaProfesional.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaProfesionalEstebanJimenez
{
    public partial class Frm_EntradaProductos : Form
    {
        public Frm_EntradaProductos()
        {
            InitializeComponent();
        }
        #region "Mis Variables"
        int Codigo_Entrada = 0;
        int Codigo_Proveedor = 0;
        int Codigo_Almacen = 0;
        int Codigo_Usuario = 0;
        int Estadoguarda = 0;
        DataTable TablaDetalle = new DataTable();
        #endregion

        #region "Mis Métodos"
        private void Formato_ep()
        {
            Dgv_principal.Columns[0].Width = 85;
            Dgv_principal.Columns[0].HeaderText = "CÓDIGO";
            Dgv_principal.Columns[1].Width = 70;
            Dgv_principal.Columns[1].HeaderText = "FACTURA";
            Dgv_principal.Columns[2].Width = 110;
            Dgv_principal.Columns[2].HeaderText = "FECHA";
            Dgv_principal.Columns[3].Width = 140;
            Dgv_principal.Columns[3].HeaderText = "USUARIO";
            Dgv_principal.Columns[4].Width = 270;
            Dgv_principal.Columns[4].HeaderText = "ALMACEN";
            Dgv_principal.Columns[5].Width = 170;
            Dgv_principal.Columns[5].HeaderText = "PROVEEDOR";
            Dgv_principal.Columns[6].Width = 140;
            Dgv_principal.Columns[6].HeaderText = "TOTAL";
            Dgv_principal.Columns[7].Visible = false;
            Dgv_principal.Columns[8].Visible = false;
            Dgv_principal.Columns[9].Visible = false;
            Dgv_principal.Columns[10].Visible = false;
            Dgv_principal.Columns[11].Visible = false;
            Dgv_principal.Columns[12].Visible = false;

        }

        private void Listado_ep(string cTexto)
        {
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

        private void Estado_Botonesprincipales(bool lEstado)
        {
            this.BtnNuevo.Enabled = lEstado;
            this.BtnEliminar.Enabled = lEstado;
            this.BtnReporte.Enabled = lEstado;
            this.BtnSalir.Enabled = lEstado;
        }

        private void Estado_Botonesprocesos(bool lEstado)
        {
            this.BtnCancelar.Visible = lEstado;
            this.BtnGuardar.Visible = lEstado;
            this.BtnRetornar.Visible = !lEstado;

            this.BtnAgregar.Visible = lEstado;
            this.BtnDeshacer.Visible = lEstado;

            this.Btn_lupa1.Visible = lEstado;
            this.Btn_lupa2.Visible = lEstado;
            this.Btn_Lupa3.Visible = lEstado;
        }

        private void Selecciona_item()
        {
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
                TxtAlmacen.Text = Dgv_principal.CurrentRow.Cells["Descripcion"].Value.ToString();
                TxtObservacion.Text = Dgv_principal.CurrentRow.Cells["Observacion"].Value.ToString();
                TxtDescripcionUsuario.Text = Dgv_principal.CurrentRow.Cells["NombreCompleto"].Value.ToString();
                TxtIva.Text = Dgv_principal.CurrentRow.Cells["Iva"].Value.ToString();
                TxtSubTotal.Text = Dgv_principal.CurrentRow.Cells["Subtotal"].Value.ToString();
                TxtTotal.Text = Dgv_principal.CurrentRow.Cells["Total"].Value.ToString();

                Dgv_Detalle.DataSource = N_EntradaProductos.Listado_detalle_Entrada(this.Codigo_Entrada);
                this.Formato_detalle();
            }

        }

        private void Crear_TablaDetalle()
        {
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
            Dgv_Detalle.Columns[0].Width = 270;
            Dgv_Detalle.Columns[0].HeaderText = "PRODUCTO";
            Dgv_Detalle.Columns[1].Width = 160;
            Dgv_Detalle.Columns[1].HeaderText = "MARCA";
            Dgv_Detalle.Columns[2].Width = 80;
            Dgv_Detalle.Columns[2].HeaderText = "U.MEDIDA";
            Dgv_Detalle.Columns[3].Width = 90;
            Dgv_Detalle.Columns[3].HeaderText = "CANTIDAD";
            Dgv_Detalle.Columns[4].Width = 110;
            Dgv_Detalle.Columns[4].HeaderText = "PRECIO UNITARIO";
            Dgv_Detalle.Columns[5].Width = 90;
            Dgv_Detalle.Columns[5].HeaderText = "TOTAL";
            Dgv_Detalle.Columns[6].Visible = false;
            Dgv_Detalle.Columns[0].ReadOnly = true;
            Dgv_Detalle.Columns[1].ReadOnly = true;
            Dgv_Detalle.Columns[2].ReadOnly = true;
            Dgv_Detalle.Columns[3].ReadOnly = true;
            Dgv_Detalle.Columns[4].ReadOnly = true;
            Dgv_Detalle.Columns[5].ReadOnly = true;
        }

       

        private void Formato_al()
        {
            DgvAlmacen.Columns[0].Width = 220;
            DgvAlmacen.Columns[0].HeaderText = "ALMACÉN";
            DgvAlmacen.Columns[1].Visible = false;

        }

        private void Listado_al()
        {
            try
            {
                DgvAlmacen.DataSource = N_EntradaProductos.Listado_al_tm();
                this.Formato_al();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Selecciona_al()
        {
            if (string.IsNullOrEmpty(Convert.ToString(DgvAlmacen.CurrentRow.Cells["Codigo_Almacen"].Value)))
            {
                MessageBox.Show("No se tiene información para Visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Codigo_Almacen = Convert.ToInt32(DgvAlmacen.CurrentRow.Cells["Codigo_Almacen"].Value);
                TxtAlmacen.Text = Convert.ToString(DgvAlmacen.CurrentRow.Cells["Descripcion"].Value);
            }
        }

        private void Formato_pv()
        {
            DgvProveedores.Columns[0].Width = 220;
            DgvProveedores.Columns[0].HeaderText = "NOMBRE";
            DgvProveedores.Columns[1].Width = 220;
            DgvProveedores.Columns[1].HeaderText = "APELLIDOS.";
            DgvProveedores.Columns[2].Width = 220;
            DgvProveedores.Columns[2].HeaderText = "RAZON SOCIAL.";
            DgvProveedores.Columns[3].Visible = false;

        }

        private void Listado_pv(string cTexto)
        {
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

        private void Formato_us()
        {
            DgvUsuarios.Columns[0].Width = 220;
            DgvUsuarios.Columns[0].HeaderText = "NOMBRE";
            DgvUsuarios.Columns[1].Width = 220;
            DgvUsuarios.Columns[1].HeaderText = "CEDULA.";
            DgvUsuarios.Columns[2].Width = 220;
            DgvUsuarios.Columns[2].HeaderText = "TELEFONO.";
            DgvUsuarios.Columns[3].Visible = false;

        }

        private void Listado_us(string cTexto)
        {
            try
            {
                DgvUsuarios.DataSource = N_EntradaProductos.Listado_us_tm(cTexto);
                this.Formato_us();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Selecciona_us()
        {
            if (string.IsNullOrEmpty(Convert.ToString(DgvUsuarios.CurrentRow.Cells["Codigo_Usuario"].Value)))
            {
                MessageBox.Show("No se tiene información para Visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Codigo_Usuario = Convert.ToInt32(DgvUsuarios.CurrentRow.Cells["Codigo_Usuario"].Value);
                TxtDescripcionUsuario.Text = Convert.ToString(DgvUsuarios.CurrentRow.Cells["NombreCompleto"].Value);
            }
        }

        private void Formato_pr()
        {
            DgvProductos.Columns[0].Width = 220;
            DgvProductos.Columns[0].HeaderText = "PRODUCTO";
            DgvProductos.Columns[1].Width = 160;
            DgvProductos.Columns[1].HeaderText = "MARCA.";
            DgvProductos.Columns[2].Width = 90;
            DgvProductos.Columns[2].HeaderText = "U.MEDIDA";
            DgvProductos.Columns[3].Width = 160;
            DgvProductos.Columns[3].HeaderText = "CATEGORÍA";
            DgvProductos.Columns[4].Visible = false;

        }

        private void Listado_pr(string cTexto)
        {
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

                xCodigo_pr = Convert.ToInt32(DgvProductos.CurrentRow.Cells["Codigo_Producto"].Value);
                foreach (DataRow Filatemp in TablaDetalle.Rows)
                {
                    if (Convert.ToInt32(Filatemp["Codigo_Producto"]) == xCodigo_pr)
                    {
                        Agregar = false;
                        MessageBox.Show("El producto ya se encuetra agregado", "Aviso del Sistema");
                    }
                }

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
            TxtNumeroDocumento.ReadOnly = !lestado;
            TxtObservacion.ReadOnly = !lestado;
            Dtp_fecha.Enabled = lestado;
        }

        private void Limpia_texto()
        {
            TxtNumeroDocumento.Text = "";
            TxtObservacion.Text = "";
            TxtSubTotal.Text = "";
            TxtIva.Text = "";
            TxtTotal.Text = "";
            this.Crear_TablaDetalle();
        }

        private void Calcular_totales()
        {

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
            this.Listado_ep("%");
            this.Listado_us("%");
            this.Listado_pv("%");
            this.Listado_al();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (
                TxtNumeroDocumento.Text == string.Empty ||
                TxtProveedor.Text == String.Empty ||
                TxtAlmacen.Text == String.Empty ||
                Dgv_Detalle.Rows.Count == 0)
            {
                MessageBox.Show("Falta ingresa datos requeridos (*)", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else //Se procedería a registrar la información
            {

                string Rpta = "";
                E_EntradaProductos oEp = new E_EntradaProductos();
                oEp.Codigo_Entrada = this.Codigo_Entrada;
                oEp.NumeroDocumento = TxtNumeroDocumento.Text.Trim();
                oEp.Fecha = Dtp_fecha.Value;
                oEp.Codigo_Usuario = this.Codigo_Usuario;
                oEp.Codigo_Almacen = this.Codigo_Almacen;
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
                    MessageBox.Show("Los datos han sido guardados correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            this.Estadoguarda = 1;
            this.Estado_Botonesprincipales(false);
            this.Estado_Botonesprocesos(true);
            this.Limpia_texto();
            Dgv_Detalle.Columns[3].ReadOnly = false;
            Dgv_Detalle.Columns[4].ReadOnly = false;
            this.Estado_texto(true);
            TbpPrincipal.SelectedIndex = 1;
            TxtNumeroDocumento.Focus();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
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
            this.Selecciona_item();
            this.Estado_Botonesprocesos(false);
            TbpPrincipal.SelectedIndex = 1;
        }

        private void BtnRetornar_Click(object sender, EventArgs e)
        {
            this.Estado_Botonesprocesos(false);
            TbpPrincipal.SelectedIndex = 0;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
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
            this.Listado_ep(TxtBuscar.Text.Trim());
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {

            Reportes.Frm_Rpt_Entrada_Productos oRpt_ep = new Reportes.Frm_Rpt_Entrada_Productos();
            oRpt_ep.txt_p1.Text = TxtBuscar.Text;
            oRpt_ep.ShowDialog();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_lupa1_Click(object sender, EventArgs e)
        {
            this.PnlProveedor.Location = BtnDeshacer.Location;
            this.PnlProveedor.Visible = true;
        }

        private void DgvProveedores_DoubleClick(object sender, EventArgs e)
        {
            this.Selecciona_pv();
            PnlProveedor.Visible = false;
        }

        private void Btn_lupa2_Click(object sender, EventArgs e)
        {
            this.PnlUs.Location = BtnDeshacer.Location;
            this.PnlUs.Visible = true;
        }

        private void BtnBuscar3_Click(object sender, EventArgs e)
        {
            this.Listado_pv(TxtBuscar3.Text);
        }

        private void BtnRetornar3_Click(object sender, EventArgs e)
        {
            PnlProveedor.Visible = false;
        }

        private void Btn_Lupa3_Click(object sender, EventArgs e)
        {
            this.PnlAlmacen.Location = Btn_Lupa3.Location;
            this.PnlAlmacen.Visible = true;
        }

        private void DgvUsuarios_DoubleClick(object sender, EventArgs e)
        {
            this.Selecciona_us();
            PnlUs.Visible = false;
        }

        private void DgvAlmacen_DoubleClick(object sender, EventArgs e)
        {
            this.Selecciona_al();
            PnlAlmacen.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PnlUs.Visible = false;
        }

        private void BtnBuscar6_Click(object sender, EventArgs e)
        {
            this.Listado_us(TxtBuscar6.Text);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            PnlProducto.Location = BtnDeshacer.Location;
            PnlProducto.Visible = true;
            TxtBuscar5.Focus();
        }

        private void DgvProductos_DoubleClick(object sender, EventArgs e)
        {
            this.Selecciona_pr();
            PnlProducto.Visible = false;
        }

        private void Dgv_Detalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.Estadoguarda == 1)
            {
                DataRow yFila = (DataRow)TablaDetalle.Rows[e.RowIndex];
                decimal yCantidad = Convert.ToDecimal(yFila["Cantidad"]);
                decimal yPu_compra = Convert.ToDecimal(yFila["PrecioUnitario"]);
                yFila["Total"] = decimal.Round(yCantidad * yPu_compra, 2).ToString("#0.00");

                this.Calcular_totales();
            }
        }

        private void BtnDeshacer_Click(object sender, EventArgs e)
        {
            if (Dgv_Detalle.Rows.Count > 0)
            {
                Dgv_Detalle.Rows.Remove(Dgv_Detalle.CurrentRow);
                Dgv_Detalle.Refresh();
                TablaDetalle.AcceptChanges();
                this.Calcular_totales();
            }
        }

        private void BtnBuscar5_Click(object sender, EventArgs e)
        {
            this.Listado_pr(TxtBuscar5.Text);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
