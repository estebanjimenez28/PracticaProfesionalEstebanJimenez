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
    public partial class FrmUnidadesMedida : Form
    {
        public FrmUnidadesMedida()
        {
            InitializeComponent();
        }

        #region "Mis Variables"
        int Codigo_Unidad = 0;

        int Estadoguarda = 0; //Sin alguna accion

        #endregion




        #region "Mis Metodos"
        private void Formato_um ()
        {
            DgvPrincipal.Columns[0].Width = 150;
            DgvPrincipal.Columns[0].HeaderText = "CÓDIGO";
            DgvPrincipal.Columns[1].Width = 400;
            DgvPrincipal.Columns[1].HeaderText = " U.MEDIDA";
            DgvPrincipal.Columns[2].Width = 350;
            DgvPrincipal.Columns[2].HeaderText = "ABREVIATURA";
        }

        private void Listado_um(string cTexto)
        {
            try
            {
                DgvPrincipal.DataSource = N_UnidadesMedida.Listado_um(cTexto);
                this.Formato_um();

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
            if (string.IsNullOrEmpty(Convert.ToString(DgvPrincipal.CurrentRow.Cells["Codigo_Unidad"].Value)))
            {
                MessageBox.Show("No se tiene informacion para visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Codigo_Unidad = Convert.ToInt32(DgvPrincipal.CurrentRow.Cells["Codigo_Unidad"].Value);
                TxtDescripcionUnidad.Text = Convert.ToString(DgvPrincipal.CurrentRow.Cells["Abreviatura"].Value);
                TxtAbreviatura.Text = Convert.ToString(DgvPrincipal.CurrentRow.Cells["Descripcion"].Value);

            }

        }
        #endregion

        private void FrmUnidadesMedida_Load(object sender, EventArgs e)
        {
            this.Listado_um("%");
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtDescripcionUnidad.Text==String.Empty||TxtAbreviatura.Text == String.Empty)
            {
                MessageBox.Show("Falta ingresar datos requeridos (*)", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else //Se procede a registrar la informacion
            {
                E_UnidadesMedida oUm = new E_UnidadesMedida();
                string Rpta = "";
                oUm.Codigo_Unidad = this.Codigo_Unidad;
                oUm.Abreviatura = TxtDescripcionUnidad.Text.Trim();
                oUm.Descripcion = TxtAbreviatura.Text.Trim();
                Rpta = N_UnidadesMedida.Guadar_um(Estadoguarda, oUm);
                if (Rpta == "OK")
                {
                    this.Listado_um("%");
                    MessageBox.Show("Los datos han sido guardados correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Estadoguarda = 0; //Sin ninguna accion
                    this.Estado_BotonesPrincipales(true);
                    this.Estado_Botonesprocesos(false);
                    TxtDescripcionUnidad.Text = "";
                    TxtAbreviatura.Text = "";
                    TxtAbreviatura.ReadOnly = true;
                    TbpPrincipal.SelectedIndex = 0;
                    this.Codigo_Unidad = 0;



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
            this.Estado_BotonesPrincipales(false);
            this.Estado_Botonesprocesos(true);
            TxtDescripcionUnidad.Text = "";
            TxtAbreviatura.Text = "";
            TxtDescripcionUnidad.ReadOnly = false;
            TxtAbreviatura.ReadOnly = false;
            TbpPrincipal.SelectedIndex = 1;
            TxtDescripcionUnidad.Focus();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            Estadoguarda = 2; //Actualizar Registro
            this.Estado_BotonesPrincipales(false);
            this.Estado_Botonesprocesos(true);
            this.Selecciona_item();
            TbpPrincipal.SelectedIndex = 1;
            TxtDescripcionUnidad.ReadOnly = false;
            TxtAbreviatura.ReadOnly = false;
            TxtAbreviatura.Focus();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Estadoguarda = 0; //Sin ninuguna accion
            this.Codigo_Unidad = 0;
            TxtAbreviatura.Text = "";
            TxtDescripcionUnidad.ReadOnly = true;
            TxtAbreviatura.ReadOnly = true;
            this.Estado_BotonesPrincipales(true);
            this.Estado_Botonesprocesos(false);
            TbpPrincipal.SelectedIndex = 0;
        }

        private void DgvPrincipal_DoubleClick(object sender, EventArgs e)
        {
            this.Selecciona_item();
            this.Estado_Botonesprocesos(false);
            TbpPrincipal.SelectedIndex = 1;
        }

        private void BtnRetornar_Click(object sender, EventArgs e)
        {
            this.Estado_Botonesprocesos(false);
            TbpPrincipal.SelectedIndex = 0;
            this.Codigo_Unidad = 0;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(DgvPrincipal.CurrentRow.Cells["Codigo_Unidad"].Value)))
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
                    this.Codigo_Unidad = Convert.ToInt32(DgvPrincipal.CurrentRow.Cells["Codigo_Unidad"].Value);
                    //Enviar a ejecutar la eliminacion de datos
                    Rpta = N_UnidadesMedida.Eliminar_um(this.Codigo_Unidad);
                    if (Rpta.Equals("OK"))
                    {
                        this.Listado_um("%");
                        this.Codigo_Unidad = 0;
                        MessageBox.Show("Registro Eliminado", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                }



            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.Listado_um(TxtBuscar.Text.Trim());
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            Reportes.Frm_Rpt_Unidades oRpt3 = new Reportes.Frm_Rpt_Unidades();
            oRpt3.txt_p1.Text = TxtBuscar.Text;
            oRpt3.ShowDialog();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
