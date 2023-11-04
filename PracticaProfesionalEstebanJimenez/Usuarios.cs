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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        #region "Mis Variables"
        int Codigo_Usuario = 0;
        int Estadoguarda = 0; //Sin ninguna acción
        #endregion

        #region "Mis Métodos"
        private void Formato_us()
        {
            DgvPrincipal.Columns[0].Width = 125;
            DgvPrincipal.Columns[0].HeaderText = "CÓDIGO";
            DgvPrincipal.Columns[1].Width = 310;
            DgvPrincipal.Columns[1].HeaderText = "USUARIO";
            DgvPrincipal.Columns[2].Width = 370;
            DgvPrincipal.Columns[2].HeaderText = "NOMBRE";
            DgvPrincipal.Columns[3].Width = 250;
            DgvPrincipal.Columns[3].HeaderText = "CARGO";
            DgvPrincipal.Columns[4].Visible = false;

        }

        private void Listado_us(string cTexto)
        {
            try
            {
                DgvPrincipal.DataSource = N_Usuarios.Listado_us(cTexto);
                this.Formato_us();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Estado_Botonesprincipales(bool lEstado)
        {
            this.BtnNuevo.Enabled = lEstado;
            this.BtnActualizar.Enabled = lEstado;
            this.BtnEliminar.Enabled = lEstado;
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
            if (string.IsNullOrEmpty(Convert.ToString(DgvPrincipal.CurrentRow.Cells["Codigo_Usuario"].Value)))
            {
                MessageBox.Show("No se tiene información para Visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                this.Codigo_Usuario = Convert.ToInt32(DgvPrincipal.CurrentRow.Cells["Codigo_Usuario"].Value);
                TxtUsuario.Text = Convert.ToString(DgvPrincipal.CurrentRow.Cells["Usuario"].Value);
                TxtNombre.Text = Convert.ToString(DgvPrincipal.CurrentRow.Cells["NombreCompleto"].Value);
                TxtCargo.Text = Convert.ToString(DgvPrincipal.CurrentRow.Cells["Cargo_Usuario"].Value);
                Chk_admin.Checked =Convert.ToBoolean(DgvPrincipal.CurrentRow.Cells["Administrador"].Value);
              
            }

        }



      


        private void Estado_texto(bool lestado)
        {
           
            TxtUsuario.ReadOnly = !lestado;
            TxtNombre.ReadOnly = !lestado;
            TxtContrasennia.ReadOnly = !lestado;
            TxtCargo.ReadOnly = !lestado;

        }

        private void Limpia_texto()
        {
            TxtUsuario.Text = "";
            TxtNombre.Text = "";
            TxtContrasennia.Text = "";
            TxtCargo.Text = "";
            
        }


        #endregion

        private void Usuarios_Load(object sender, EventArgs e)
        {
            this.Listado_us("%");
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtContrasennia.Text == String.Empty && this.Estadoguarda == 1)
            {
                MessageBox.Show("Falta ingresa datos requeridos (*)",
                                "Aviso del Sistema",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (TxtUsuario.Text == String.Empty ||
                        TxtNombre.Text == String.Empty)
                {
                    MessageBox.Show("Falta ingresa datos requeridos (*)", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else //Se procedería a registrar la información
                {
                    E_Usuarios oUs = new E_Usuarios();
                    string Rpta = "";
                    oUs.Codigo_Usuario = this.Codigo_Usuario;
                    oUs.Usuario = TxtUsuario.Text.Trim();
                    oUs.Contrasennia = TxtContrasennia.Text.Trim();
                    oUs.Nombre_Completo = TxtNombre.Text.Trim();
                    oUs.Cargo_Usuario = TxtCargo.Text.Trim();
                    oUs.Admin = Chk_admin.Checked;

                    Rpta = N_Usuarios.Guadar_us(Estadoguarda, oUs);
                    if (Rpta == "OK")
                    {
                        this.Listado_us("%");
                        MessageBox.Show("Los datos han sido guardados correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Estadoguarda = 0; //Sin nunguna acción
                        this.Estado_Botonesprincipales(true);
                        this.Estado_Botonesprocesos(false);
                        TxtUsuario.Text = "";
                        TxtContrasennia.Text = "";
                        TxtNombre.Text = "";
                        TxtCargo.Text = "";
                        Chk_admin.Checked = false;

                        TxtUsuario.ReadOnly = true;
                        TxtContrasennia.ReadOnly = true;
                        TxtNombre.ReadOnly = true;
                        TxtCargo.ReadOnly = true;
                        Chk_admin.Enabled = false;
                        TbpPrincipal.SelectedIndex = 0;
                        this.Codigo_Usuario = 0;

                    }
                    else
                    {
                        MessageBox.Show(Rpta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnRetornar_Click(object sender, EventArgs e)
        {
            this.Estado_Botonesprocesos(false);
            TbpPrincipal.SelectedIndex = 0;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Codigo_Usuario = 0;

            TxtUsuario.Text = "";
            TxtContrasennia.Text = "";
            TxtNombre.Text = "";
            TxtCargo.Text = "";
            Chk_admin.Checked = false;

            TxtUsuario.ReadOnly = true;
            TxtContrasennia.ReadOnly = true;
            TxtNombre.ReadOnly = true;
            TxtCargo.ReadOnly = true;
            Chk_admin.Enabled = false;
            TbpPrincipal.SelectedIndex = 0;
            this.Codigo_Usuario = 0;

            this.Estado_Botonesprincipales(true);
            this.Estado_Botonesprocesos(false);
            TbpPrincipal.SelectedIndex = 0;
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            Estadoguarda = 1; //Nuevo Registro           
            this.Estado_Botonesprincipales(false);
            this.Estado_Botonesprocesos(true);
            TxtUsuario.Text = "";
            TxtContrasennia.Text = "";
            TxtNombre.Text = "";
            TxtCargo.Text = "";
            Chk_admin.Checked = false;

            TxtUsuario.ReadOnly = false;
            TxtContrasennia.ReadOnly = false;
            TxtNombre.ReadOnly = false;
            TxtCargo.ReadOnly = false;
            Chk_admin.Enabled = true;
            TbpPrincipal.SelectedIndex = 1;
            TxtUsuario.Focus(); 
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            Estadoguarda = 2; //Actualizar Registro           
            this.Estado_Botonesprincipales(false);
            this.Estado_Botonesprocesos(true);
           TbpPrincipal.SelectedIndex = 1;

           
            TxtContrasennia.ReadOnly = false;   
            TxtNombre.ReadOnly= false;  
            TxtCargo.ReadOnly= false;   
            Chk_admin.Enabled = true;   

            TxtContrasennia.Focus();    
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(DgvPrincipal.CurrentRow.Cells["Codigo_Usuario"].Value)))
            {
                MessageBox.Show("No se tiene información para Visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Estás seguro de eliminar el registro seleccionado?", "Aviso del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Opcion == DialogResult.Yes)
                {
                    string Rpta = "";
                    this.Codigo_Usuario = Convert.ToInt32(DgvPrincipal.CurrentRow.Cells["Codigo_Usuario"].Value);
                    Rpta = N_Usuarios.Eliminar_us(this.Codigo_Usuario);
                    if (Rpta.Equals("OK"))
                    {
                        this.Listado_us("%");
                        this.Codigo_Usuario = 0;
                        MessageBox.Show("Registro Eliminado", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }



            }
        }

    

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.Listado_us(TxtBuscar.Text.Trim());
        }

        private void DgvPrincipal_DoubleClick(object sender, EventArgs e)
        {
            this.Selecciona_item();
            this.Estado_Botonesprocesos(false);
            TbpPrincipal.SelectedIndex = 1;
        }

      
    }
}
