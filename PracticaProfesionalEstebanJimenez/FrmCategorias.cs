using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PracticaProfesional.Entidades;
using PracticaProfesional.Negocio;

namespace PracticaProfesionalEstebanJimenez
{
    public partial class FrmCategorias : Form
    {
        public FrmCategorias()
        {
            InitializeComponent();
        }
        #region "Mis Variables"
        int Codigo_Categoria = 0;

        int Estadoguarda = 0; //Sin alguna accion

        #endregion

        


        #region "Mis Metodos"
        private void Formato_ca()
        {
            DgvPrincipal.Columns[0].Width = 250;
            DgvPrincipal.Columns[0].HeaderText = "CÓDIGO";
            DgvPrincipal.Columns[1].Width = 650;
            DgvPrincipal.Columns[1].HeaderText = "CATEGORÍA";
        }

        private void Listado_ca(string cTexto)
        {
            try
            {
                DgvPrincipal.DataSource = N_Categorias.Listado_ca(cTexto);
                this.Formato_ca();

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
           if(string.IsNullOrEmpty(Convert.ToString(DgvPrincipal.CurrentRow.Cells["Codigo_Categoria"].Value)))
            {
                MessageBox.Show("No se tiene informacion para visualizar","Aviso del Sistema",MessageBoxButtons.OK, MessageBoxIcon.Error);  
            }
            else
            {
                this.Codigo_Categoria = Convert.ToInt32(DgvPrincipal.CurrentRow.Cells["Codigo_Categoria"].Value);
                TxtDescripcionCategoria.Text = Convert.ToString(DgvPrincipal.CurrentRow.Cells["Descripcion"].Value);
            }
          
        }
        #endregion

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            this.Listado_ca("%");
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if(TxtDescripcionCategoria.Text == String.Empty)
            {
                MessageBox.Show("Falta ingresar datos requeridos (*)", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else //Se procede a registrar la informacion
            {
                E_Categorias oCa = new E_Categorias();
                string Rpta = "";
                oCa.Codigo_Categoria = this.Codigo_Categoria;
                oCa.Descripcion_Categoria = TxtDescripcionCategoria.Text.Trim();
                Rpta = N_Categorias.Guadar_ca(Estadoguarda,oCa);
                if(Rpta =="OK")
                {
                    this.Listado_ca("%");
                    MessageBox.Show("Los datos han sido guardados correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Estadoguarda = 0; //Sin ninguna accion
                    this.Estado_BotonesPrincipales(true);
                    this.Estado_Botonesprocesos(false);
                    TxtDescripcionCategoria.Text = "";
                    TxtDescripcionCategoria.ReadOnly = true;
                    TbpPrincipal.SelectedIndex = 0;
                    this.Codigo_Categoria = 0;


                  
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
            TxtDescripcionCategoria.Text = "";
            TxtDescripcionCategoria.ReadOnly = false;
            TbpPrincipal.SelectedIndex = 1;
            TxtDescripcionCategoria.Focus();

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            Estadoguarda = 2; //Actualizar Registro
            this.Estado_BotonesPrincipales(false);
            this.Estado_Botonesprocesos(true);
            this.Selecciona_item();
            TbpPrincipal.SelectedIndex = 1;
            TxtDescripcionCategoria.ReadOnly = false;
            TxtDescripcionCategoria.Focus();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Estadoguarda = 0; //Sin ninuguna accion
            this.Codigo_Categoria = 0;
            TxtDescripcionCategoria.Text = "";
            TxtDescripcionCategoria.ReadOnly = true;
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
            this.Codigo_Categoria = 0;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(DgvPrincipal.CurrentRow.Cells["Codigo_Categoria"].Value)))
            {
                MessageBox.Show("No se tiene informacion para visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                DialogResult Opcion;
                Opcion = MessageBox.Show("Estas seguro de eliminar el registro seleccionado?", "Aviso del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(Opcion == DialogResult.Yes)
                {

                    string Rpta = "";
                    this.Codigo_Categoria = Convert.ToInt32(DgvPrincipal.CurrentRow.Cells["Codigo_Categoria"].Value);
                    //Enviar a ejecutar la eliminacion de datos
                    Rpta = N_Categorias.Eliminar_ca(this.Codigo_Categoria);
                    if(Rpta.Equals("OK"))
                        {
                        this.Listado_ca("%");
                        this.Codigo_Categoria = 0;
                        MessageBox.Show("Registro Eliminado", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                }


                
            }

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.Listado_ca(TxtBuscar.Text.Trim());
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            Reportes.Frm_Rpt_Categorias oRpt1 = new Reportes.Frm_Rpt_Categorias();
            oRpt1.txt_p1.Text = TxtBuscar.Text;
            oRpt1.ShowDialog();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
