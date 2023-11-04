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
    public partial class FrmMarcas : Form
    {
        public FrmMarcas()
        {
            InitializeComponent();
        }
            #region "Mis Variables"
        int Codigo_Marca = 0;

        int Estadoguarda = 0; //Sin alguna accion

        #endregion

        


        #region "Mis Metodos"
        private void Formato_ma()
        {
            DgvPrincipal.Columns[0].Width = 300;
            DgvPrincipal.Columns[0].HeaderText = "CÓDIGO";
            DgvPrincipal.Columns[1].Width = 650;
            DgvPrincipal.Columns[1].HeaderText = "MARCA";
        }

        private void Listado_ma(string cTexto)
        {
            try
            {
                DgvPrincipal.DataSource = N_Marcas.Listado_ma(cTexto);
                this.Formato_ma();

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
           if(string.IsNullOrEmpty(Convert.ToString(DgvPrincipal.CurrentRow.Cells["Codigo_Marca"].Value)))
            {
                MessageBox.Show("No se tiene informacion para visualizar","Aviso del Sistema",MessageBoxButtons.OK, MessageBoxIcon.Error);  
            }
            else
            {
                this.Codigo_Marca = Convert.ToInt32(DgvPrincipal.CurrentRow.Cells["Codigo_Marca"].Value);
                TxtDescripcionMarca.Text = Convert.ToString(DgvPrincipal.CurrentRow.Cells["Descripcion_Marca"].Value);
            }
          
        }
        #endregion
        private void FrmMarcas_Load(object sender, EventArgs e)
        {
            this.Listado_ma("%");
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtDescripcionMarca.Text == String.Empty)
            {
                MessageBox.Show("Falta ingresar datos requeridos (*)", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else //Se procede a registrar la informacion
            {
                E_Marcas oMa = new E_Marcas();
                string Rpta = "";
                oMa.Codigo_Marca = this.Codigo_Marca;
                oMa.Descripcion_Marca = TxtDescripcionMarca.Text.Trim();
                Rpta = N_Marcas.Guadar_ma(Estadoguarda, oMa);
                if (Rpta == "OK")
                {
                    this.Listado_ma("%");
                    MessageBox.Show("Los datos han sido guardados correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Estadoguarda = 0; //Sin ninguna accion
                    this.Estado_BotonesPrincipales(true);
                    this.Estado_Botonesprocesos(false);
                    TxtDescripcionMarca.Text = "";
                    TxtDescripcionMarca.ReadOnly = true;
                    TbpPrincipal.SelectedIndex = 0;
                    this.Codigo_Marca = 0;



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
            TxtDescripcionMarca.Text = "";
            TxtDescripcionMarca.ReadOnly = false;
            TbpPrincipal.SelectedIndex = 1;
            TxtDescripcionMarca.Focus();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            Estadoguarda = 2; //Actualizar Registro
            this.Estado_BotonesPrincipales(false);
            this.Estado_Botonesprocesos(true);
            this.Selecciona_item();
            TbpPrincipal.SelectedIndex = 1;
            TxtDescripcionMarca.ReadOnly = false;
            TxtDescripcionMarca.Focus();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Estadoguarda = 0; //Sin ninuguna accion
            this.Codigo_Marca = 0;
            TxtDescripcionMarca.Text = "";
            TxtDescripcionMarca.ReadOnly = true;
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
            this.Codigo_Marca = 0;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(DgvPrincipal.CurrentRow.Cells["Codigo_Marca"].Value)))
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
                    this.Codigo_Marca = Convert.ToInt32(DgvPrincipal.CurrentRow.Cells["Codigo_Marca"].Value);
                    //Enviar a ejecutar la eliminacion de datos
                    Rpta = N_Marcas.Eliminar_ma(this.Codigo_Marca);
                    if (Rpta.Equals("OK"))
                    {
                        this.Listado_ma("%");
                        this.Codigo_Marca = 0;
                        MessageBox.Show("Registro Eliminado", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                }



            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.Listado_ma(TxtBuscar.Text.Trim());
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
           Reportes.Frm_Rpt_Marcas oRpt2 = new Reportes.Frm_Rpt_Marcas();
            oRpt2.txt_p1.Text = TxtBuscar.Text;
            oRpt2.ShowDialog();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();   

        }
    }
}
