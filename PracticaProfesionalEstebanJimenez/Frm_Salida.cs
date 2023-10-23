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
    public partial class Frm_Salida : Form
    {
        public Frm_Salida()
        {
            InitializeComponent();
        }
        #region "Mis Variables"
        int Codigo_Salida = 0;
        int Codigo_TipoVenta = 0;
        int Codigo_Cliente = 0;

        int Estadoguarda = 0;
        DataTable TablaDetalle = new DataTable();
        #endregion

        #region "Mis Métodos"
        private void Formato_sp()
        {
            Dgv_principal.Columns[0].Width = 85;
            Dgv_principal.Columns[0].HeaderText = "CÓDIGO_SALIDA";
            Dgv_principal.Columns[1].Width = 70;
            Dgv_principal.Columns[1].HeaderText = "TIPO VENTA";
            Dgv_principal.Columns[2].Width = 110;
            Dgv_principal.Columns[2].HeaderText = "NRO DOC";
            Dgv_principal.Columns[3].Width = 140;
            Dgv_principal.Columns[3].HeaderText = "FECHA VENTA";
            Dgv_principal.Columns[4].Width = 270;
            Dgv_principal.Columns[4].HeaderText = "NRO.DOC.CLI";
            Dgv_principal.Columns[5].Width = 170;
            Dgv_principal.Columns[5].HeaderText = "CLIENTE";
            Dgv_principal.Columns[6].Width = 140;
            Dgv_principal.Columns[6].HeaderText = "TOTAL";
            Dgv_principal.Columns[7].Visible = false;
            Dgv_principal.Columns[8].Visible = false;
            Dgv_principal.Columns[9].Visible = false;
            Dgv_principal.Columns[10].Visible = false;
            Dgv_principal.Columns[11].Visible = false;
        }

        private void Listado_sp(string cTexto)
        {
            try
            {
                Dgv_principal.DataSource = N_SalidaProductos.Listado_Salida(cTexto);
                this.Formato_sp();
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

            this.BtnAgregar.Visible = lEstado;
            this.BtnDeshacer.Visible = lEstado;

            this.btn_lupa1.Visible = lEstado;
            this.Btn_lupa2.Visible = lEstado;
        }

        private void Selecciona_item()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_principal.CurrentRow.Cells["Codigo_Salida"].Value)))
            {
                MessageBox.Show("No se tiene información para Visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Codigo_Salida = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["Codigo_Salida"].Value);
                this.Codigo_TipoVenta = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["Codigo_TipoVenta"].Value);
                this.Codigo_Cliente = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["Codigo_Cliente"].Value);
                TxtDescripcionTipoVenta.Text = Dgv_principal.CurrentRow.Cells["DescripcionVenta"].Value.ToString();
                TxtNumeroDocumento.Text = Dgv_principal.CurrentRow.Cells["NumeroDocumento"].Value.ToString();
                Dtp_fecha.Value = Convert.ToDateTime(Dgv_principal.CurrentRow.Cells["Fecha_Salida"].Value);
                TxtCliente.Text = Dgv_principal.CurrentRow.Cells["RazonSocial_Cliente"].Value.ToString();
                TxtDocumentoCliente.Text = Dgv_principal.CurrentRow.Cells["NumeroDocumento_Cliente"].Value.ToString();
                TxtObservacion.Text = Dgv_principal.CurrentRow.Cells["Observacion"].Value.ToString();
                TxtSubTotal.Text = Dgv_principal.CurrentRow.Cells["Subtotal"].Value.ToString();
                TxtIva.Text = Dgv_principal.CurrentRow.Cells["Iva"].Value.ToString();
                TxtTotal.Text = Dgv_principal.CurrentRow.Cells["Total"].Value.ToString();

                Dgv_Detalle.DataSource = N_SalidaProductos.Listado__detalle_Salida(this.Codigo_Salida);
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
            this.TablaDetalle.Columns.Add("Precio_Venta", System.Type.GetType("System.Decimal"));
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
                                  decimal nPu_venta,
                                  decimal nTotal,
                                  int nCodigo_pr)
        {
            DataRow xFila = TablaDetalle.NewRow();
            xFila["Descripcion_Producto"] = cDescripcion_pr;
            xFila["Descripcion_Marca"] = cDescripcion_ma;
            xFila["Descripcion_Unidad"] = cDescripcion_um;
            xFila["Cantidad"] = nCantidad;
            xFila["Precio_Venta"] = nPu_venta;
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
            Dgv_Detalle.Columns[4].HeaderText = "PU VENTA";
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

        private void Formato_TipoVenta()
        {
            DgvTipoVenta.Columns[0].Width = 200;
            DgvTipoVenta.Columns[0].HeaderText = "TIPO VENTA";
            DgvTipoVenta.Columns[1].Visible = false;

        }
        private void Listado_TipoVenta()
        {
            try
            {
                DgvTipoVenta.DataSource = N_SalidaProductos.Listado_TipoVenta();
                this.Formato_TipoVenta();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Selecciona_item_tde()
        {
            if (string.IsNullOrEmpty(Convert.ToString(DgvTipoVenta.CurrentRow.Cells["Codigo_TipoVenta"].Value)))
            {
                MessageBox.Show("No se tiene información para Visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Codigo_TipoVenta = Convert.ToInt32(DgvTipoVenta.CurrentRow.Cells["Codigo_TipoVenta"].Value);
                TxtDescripcionTipoVenta.Text = Convert.ToString(DgvTipoVenta.CurrentRow.Cells["DescripcionVenta"].Value);
            }
        }






        private void Formato_cl()
        {
            DgvClientes.Columns[0].Width = 220;
            DgvClientes.Columns[0].HeaderText = "CLIENTE";
            DgvClientes.Columns[1].Width = 220;
            DgvClientes.Columns[1].HeaderText = "TIPO.";
            DgvClientes.Columns[2].Width = 220;
            DgvClientes.Columns[2].HeaderText = "NRO. DOC.";
            DgvClientes.Columns[3].Visible = false;

        }

        private void Listado_cl(string cTexto)
        {
            try
            {
                DgvClientes.DataSource = N_SalidaProductos.Listado_cl_sp(cTexto);
                this.Formato_cl();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Selecciona_cl()
        {
            if (string.IsNullOrEmpty(Convert.ToString(DgvClientes.CurrentRow.Cells["Codigo_Cliente"].Value)))
            {
                MessageBox.Show("No se tiene información para Visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Codigo_Cliente = Convert.ToInt32(DgvClientes.CurrentRow.Cells["Codigo_Cliente"].Value);
                TxtDocumentoCliente.Text = Convert.ToString(DgvClientes.CurrentRow.Cells["NumeroDocumento_Cliente"].Value);
                TxtCliente.Text = Convert.ToString(DgvClientes.CurrentRow.Cells["Razon_Social_Cliente"].Value);
                if (this.Codigo_Cliente == 4) //si es el cliente genérico
                {
                    TxtDocumentoCliente.ReadOnly = false;
                    TxtCliente.ReadOnly = false;
                    TxtDocumentoCliente.Focus();
                }
                else // para los demás cliente
                {
                    TxtDocumentoCliente.ReadOnly = true;
                    TxtCliente.ReadOnly = true;
                }
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
            DgvProductos.Columns[4].Width = 100;
            DgvProductos.Columns[4].HeaderText = "STOCK ACTUAL";
            DgvProductos.Columns[5].Width = 100;
            DgvProductos.Columns[5].HeaderText = "PU VENTA";
            DgvProductos.Columns[6].Visible = false;

        }

        private void Listado_pr(string cTexto)
        {
            try
            {
                DgvProductos.DataSource = N_SalidaProductos.Listado_pr_sp(cTexto);
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
                decimal xPu_venta;
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
                    xCantidad = Convert.ToDecimal(DgvProductos.CurrentRow.Cells["Stock_Actual"].Value);
                    xPu_venta = Convert.ToDecimal(DgvProductos.CurrentRow.Cells["Precio_Venta"].Value);
                    xTotal = decimal.Round(xCantidad * xPu_venta, 2);


                    this.Agregar_item(xDescripcion_pr,
                                      xDescripcion_ma,
                                      xDescripcion_um,
                                      xCantidad,
                                      xPu_venta,
                                      xTotal,
                                      xCodigo_pr);

                    this.Calcular_totales();
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

                TxtSubTotal.Text = decimal.Round(nSubtotal, 2).ToString("#0.00");
                TxtIva.Text = decimal.Round(nIgv, 2).ToString("#0.00");
                TxtTotal.Text = decimal.Round(nTotal_importe, 2).ToString("#0.00");
            }

        }
        #endregion

        private void Frm_Salida_Load(object sender, EventArgs e)
        {
            this.Listado_TipoVenta();
            this.Listado_cl("%");
            this.Listado_sp("%");
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtDescripcionTipoVenta.Text == String.Empty ||
               TxtNumeroDocumento.Text == string.Empty ||
               TxtCliente.Text == String.Empty ||
               Dgv_Detalle.Rows.Count == 0)
            {
                MessageBox.Show("Falta ingresa datos requeridos (*)", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else //Se procedería a registrar la información
            {

                string Rpta = "";
                E_SalidaProductos oSp = new E_SalidaProductos();
                oSp.Codigo_Salida = this.Codigo_Salida;
                oSp.Codigo_TipoVenta = this.Codigo_TipoVenta;
                oSp.NumeroDocumento = TxtNumeroDocumento.Text.Trim();
                oSp.Codigo_Ciente= this.Codigo_Cliente;
                oSp.nDocumentoCliente = TxtDocumentoCliente.Text.Trim();
                oSp.RazonSocial_Cliente = TxtCliente.Text.Trim();
                oSp.Fecha_Salida = Dtp_fecha.Value;
                oSp.Observacion = TxtObservacion.Text.Trim();
                oSp.Subtotal = Convert.ToDecimal(TxtSubTotal.Text.Trim());
                oSp.Iva = Convert.ToDecimal(TxtIva.Text.Trim());
                oSp.Total = Convert.ToDecimal(TxtTotal.Text.Trim());

                this.TablaDetalle.AcceptChanges();

                Rpta = N_SalidaProductos.Guardar_Salida(oSp, TablaDetalle);
                if (Rpta != String.Empty)
                {
                    int codigoSalida;
                    if (int.TryParse(Rpta, out codigoSalida))
                    {
                        this.Codigo_Salida = codigoSalida;
                    }
                    MessageBox.Show("Los datos han sido guardados correctamente # " + this.Codigo_Salida, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Generando el ticket de la venta
                    Reportes.Frm_Rpt_Imprimir_VentaGeneral oRpt_print = new Reportes.Frm_Rpt_Imprimir_VentaGeneral();
                    oRpt_print.txt_p1.Text = Convert.ToString(this.Codigo_Salida);
                    oRpt_print.ShowDialog();
                    //fin del proceso del ticket para imprimir

                    this.Estado_Botonesprincipales(true);
                    this.Estado_Botonesprocesos(false);
                    this.Estado_texto(false);
                    Dgv_Detalle.Columns[3].ReadOnly = true;
                    TbpPrincipal.SelectedIndex = 0;
                    this.Codigo_Salida = 0;
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
            this.Estado_texto(true);
            TbpPrincipal.SelectedIndex = 0;
            TxtNumeroDocumento.Focus();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Codigo_Salida = 0;
            this.Codigo_TipoVenta= 0;
            this.Codigo_Cliente = 0;
            this.Estadoguarda = 0;

            this.Estado_texto(false);
            this.Limpia_texto();
            Dgv_Detalle.Columns[3].ReadOnly = true;

            this.Estado_Botonesprincipales(true);
            this.Estado_Botonesprocesos(false);
            TbpPrincipal.SelectedIndex = 0;
        }

        private void Dgv_principal_DoubleClick(object sender, EventArgs e)
        {
            this.Selecciona_item();
            this.Estado_Botonesprocesos(false);
            TbpPrincipal.SelectedIndex = 0;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_principal.CurrentRow.Cells["Codigo_Salida"].Value)))
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
                    this.Codigo_Salida = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["Codigo_Salida"].Value);
                    Rpta = N_SalidaProductos.Eliminar_sp(this.Codigo_Salida);
                    if (Rpta.Equals("OK"))
                    {
                        this.Listado_sp("%");
                        this.Limpia_texto();
                        this.Codigo_Salida = 0;
                        MessageBox.Show("Registro Anulado", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        TbpPrincipal.SelectedIndex = 1;
                    }
                }



            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.Listado_sp(TxtBuscar.Text.Trim());
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            Reportes.Frm_Rpt_Salida_Productos oRpt_sp = new Reportes.Frm_Rpt_Salida_Productos();
            oRpt_sp.txt_p1.Text = TxtBuscar.Text;
            oRpt_sp.ShowDialog();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_lupa1_Click(object sender, EventArgs e)
        {
            this.PnlTipoVenta.Location = btn_lupa1.Location;
            this.PnlTipoVenta.Visible = true;
        }

        private void DgvTipoVenta_DoubleClick(object sender, EventArgs e)
        {
            this.Selecciona_item_tde();
            PnlTipoVenta.Visible = false;
            TxtNumeroDocumento.Focus();
        }

        private void Btn_lupa2_Click(object sender, EventArgs e)
        {
            this.PnlClientes.Location = btn_lupa1.Location;
            this.PnlClientes.Visible = true;
        }

        private void BtnBuscar3_Click(object sender, EventArgs e)
        {
            this.Listado_cl(TxtBuscar3.Text);
        }

        private void BtnRetornar3_Click(object sender, EventArgs e)
        {
            PnlClientes.Visible = false;
        }

        private void DgvClientes_DoubleClick(object sender, EventArgs e)
        {
            this.Selecciona_cl();
            PnlClientes.Visible = false;
        }

        private void BtnBuscar5_Click(object sender, EventArgs e)
        {
            this.Listado_pr(TxtBuscar5.Text);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            PnlProducto.Location = TxtNumeroDocumento.Location;
            PnlProducto.Visible = true;
            TxtBuscar5.Focus();
        }

        private void BtnRetornar5_Click(object sender, EventArgs e)
        {
            PnlProducto.Visible = false;
        }

        private void Dgv_Detalle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (this.Estadoguarda == 1)
            {
                DataRow yFila = (DataRow)TablaDetalle.Rows[e.RowIndex];
                decimal yCantidad = Convert.ToDecimal(yFila["Cantidad"]);
                decimal yPu_venta = Convert.ToDecimal(yFila["Precio_Venta"]);
                yFila["Total"] = decimal.Round(yCantidad * yPu_venta, 2).ToString("#0.00");

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

        private void DgvProductos_DoubleClick(object sender, EventArgs e)
        {
            this.Selecciona_pr();
            PnlProducto.Visible = false;
        }

        private void BtnRetornar_Click(object sender, EventArgs e)
        {
            TbpPrincipal.SelectedIndex = 0;
        }
    }
}
