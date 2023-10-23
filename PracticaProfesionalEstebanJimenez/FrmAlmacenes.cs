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
    public partial class FrmAlmacenes : Form
    {
        public FrmAlmacenes()
        {
            InitializeComponent();
        }

        #region "Mis Variables"
        int Codigo_Almacen = 0;

        int Estadoguarda = 0; //Sin alguna accion

        #endregion




        #region "Mis Metodos"
        private void Formato_al()
        {
            DgvPrincipal.Columns[0].Width = 100;
            DgvPrincipal.Columns[0].HeaderText = "Código";
            DgvPrincipal.Columns[1].Width = 300;
            DgvPrincipal.Columns[1].HeaderText = "Almacen";
        }

        private void Listado_al(string cTexto)
        {
            try
            {
                DgvPrincipal.DataSource = N_Almacen.Listado_al(cTexto);
                this.Formato_al();

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
            if (string.IsNullOrEmpty(Convert.ToString(DgvPrincipal.CurrentRow.Cells["Codigo_Almacen"].Value)))
            {
                MessageBox.Show("No se tiene informacion para visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Codigo_Almacen = Convert.ToInt32(DgvPrincipal.CurrentRow.Cells["Codigo_Almacen"].Value);
                TxtDescripcionAlmacen.Text = Convert.ToString(DgvPrincipal.CurrentRow.Cells["Descripcion"].Value);
            }

        }
        #endregion

        private void FrmAlmacenes_Load(object sender, EventArgs e)
        {
            this.Listado_al("%");

        }


     

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtDescripcionAlmacen.Text == String.Empty)
            {
                MessageBox.Show("Falta ingresar datos requeridos (*)", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else //Se procede a registrar la informacion
            {
                E_Almacen oAl = new E_Almacen();
                string Rpta = "";
                oAl.Codigo_Almacen = this.Codigo_Almacen;
                oAl.Descripcion_Almacen = TxtDescripcionAlmacen.Text.Trim();
                Rpta = N_Almacen.Guadar_al(Estadoguarda, oAl);
                if (Rpta == "OK")
                {
                    this.Listado_al("%");
                    MessageBox.Show("Los datos han sido guardados correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Estadoguarda = 0; //Sin ninguna accion
                    this.Estado_BotonesPrincipales(true);
                    this.Estado_Botonesprocesos(false);
                    TxtDescripcionAlmacen.Text = "";
                    TxtDescripcionAlmacen.ReadOnly = true;
                    TbpPrincipal.SelectedIndex = 0;
                    this.Codigo_Almacen = 0;



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
            TxtDescripcionAlmacen.Text = "";
            TxtDescripcionAlmacen.ReadOnly = false;
            TbpPrincipal.SelectedIndex = 1;
            TxtDescripcionAlmacen.Focus();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            Estadoguarda = 2; //Actualizar Registro
            this.Estado_BotonesPrincipales(false);
            this.Estado_Botonesprocesos(true);
            this.Selecciona_item();
            TbpPrincipal.SelectedIndex = 1;
            TxtDescripcionAlmacen.ReadOnly = false;
            TxtDescripcionAlmacen.Focus();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Estadoguarda = 0; //Sin ninuguna accion
            this.Codigo_Almacen = 0;
            TxtDescripcionAlmacen.Text = "";
            TxtDescripcionAlmacen.ReadOnly = true;
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
            this.Codigo_Almacen = 0;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(DgvPrincipal.CurrentRow.Cells["Codigo_Almacen"].Value)))
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
                    this.Codigo_Almacen = Convert.ToInt32(DgvPrincipal.CurrentRow.Cells["Codigo_Almacen"].Value);
                    //Enviar a ejecutar la eliminacion de datos
                    Rpta = N_Almacen.Eliminar_al(this.Codigo_Almacen);
                    if (Rpta.Equals("OK"))
                    {
                        this.Listado_al("%");
                        this.Codigo_Almacen = 0;
                        MessageBox.Show("Registro Eliminado", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                }



            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.Listado_al(TxtBuscar.Text.Trim());
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            Reportes.Frm_Rpt_Almacenes oRpt3 = new Reportes.Frm_Rpt_Almacenes();
            oRpt3.txt_p1.Text = TxtBuscar.Text;
            oRpt3.ShowDialog();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
