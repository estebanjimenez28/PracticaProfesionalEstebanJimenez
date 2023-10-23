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
        int Codigo_Rol = 0;
        int Estadoguarda = 0; //Sin ninguna acción
        #endregion

        #region "Mis Métodos"
        private void Formato_us()
        {
            DgvPrincipal.Columns[0].Width = 85;
            DgvPrincipal.Columns[0].HeaderText = "CÓDIGO";
            DgvPrincipal.Columns[1].Width = 110;
            DgvPrincipal.Columns[1].HeaderText = "CEDULA";
            DgvPrincipal.Columns[2].Width = 270;
            DgvPrincipal.Columns[2].HeaderText = "USUARIO";
            DgvPrincipal.Columns[3].Width = 150;
            DgvPrincipal.Columns[3].HeaderText = "NOMBRE";
            DgvPrincipal.Columns[4].Width = 150;
            DgvPrincipal.Columns[4].HeaderText = "ROL";
            DgvPrincipal.Columns[5].Width = 200;
            DgvPrincipal.Columns[5].HeaderText = "CONTRASEÑA";
            DgvPrincipal.Columns[6].Visible = false;

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
            if (string.IsNullOrEmpty(Convert.ToString(DgvPrincipal.CurrentRow.Cells["Codigo_Usuario"].Value)))
            {
                MessageBox.Show("No se tiene información para Visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                this.Codigo_Usuario = Convert.ToInt32(DgvPrincipal.CurrentRow.Cells["Codigo_Usuario"].Value);
                TxtUsuario.Text = Convert.ToString(DgvPrincipal.CurrentRow.Cells["Usuario"].Value);
                TxtContrasennia.Text = Convert.ToString(DgvPrincipal.CurrentRow.Cells["Contrasennia"].Value);
                TxtNombre.Text = Convert.ToString(DgvPrincipal.CurrentRow.Cells["NombreCompleto"].Value);
                TxtCedula.Text = Convert.ToString(DgvPrincipal.CurrentRow.Cells["Cedula"].Value);
                TxtTelefono.Text = Convert.ToString(DgvPrincipal.CurrentRow.Cells["Telefono"].Value);
                TxtDireccion.Text = Convert.ToString(DgvPrincipal.CurrentRow.Cells["Direccion"].Value);
                TxtRol.Text = Convert.ToString(DgvPrincipal.CurrentRow.Cells["Descripcion"].Value);
            }

        }



        private void Formato_rl_us()
        {
            DgvRolUsuario.Columns[0].Width = 300;
            DgvRolUsuario.Columns[0].HeaderText = "ROL USUARIO";
            DgvRolUsuario.Columns[1].Visible = false;

        }

        private void Listado_rl_us(string cTexto)
        {
            try
            {
                DgvRolUsuario.DataSource = N_Usuarios.Listado_rl_us(cTexto);
                this.Formato_rl_us();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Selecciona_rl_us()
        {
            if (string.IsNullOrEmpty(Convert.ToString(DgvRolUsuario.CurrentRow.Cells["Codigo_Rol"].Value)))
            {
                MessageBox.Show("No se tiene información para Visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Codigo_Rol = Convert.ToInt32(DgvRolUsuario.CurrentRow.Cells["Codigo_Rol"].Value);
                TxtRol.Text = Convert.ToString(DgvRolUsuario.CurrentRow.Cells["Descripcion"].Value);
            }
        }


        private void Estado_texto(bool lestado)
        {
            TxtCedula.ReadOnly = !lestado;
            TxtUsuario.ReadOnly = !lestado;
            TxtNombre.ReadOnly = !lestado;
            TxtContrasennia.ReadOnly = !lestado;
            TxtTelefono.ReadOnly = !lestado;
            TxtDireccion.ReadOnly = !lestado;
        }

        private void Limpia_texto()
        {
            TxtCedula.Text = "";
            TxtUsuario.Text = "";
            TxtNombre.Text = "";
            TxtContrasennia.Text = "";
            TxtTelefono.Text = "";
            TxtDireccion.Text = "";
            
        }


        #endregion

        private void Usuarios_Load(object sender, EventArgs e)
        {
            this.Listado_us("%");
            this.Listado_rl_us("%");
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtCedula.Text == String.Empty ||
               TxtRol.Text == String.Empty ||
               TxtUsuario.Text == String.Empty ||
               TxtDireccion.Text == String.Empty)
            {
                MessageBox.Show("Falta ingresa datos requeridos (*)", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else //Se procedería a registrar la información
            {

                string Rpta = "";
                E_Usuarios oUs = new E_Usuarios();
                oUs.Codigo_Usuario = this.Codigo_Usuario;
                oUs.Cedula = TxtCedula.Text.Trim();
                oUs.Usuario = TxtUsuario.Text.Trim();
                oUs.Nombre_Completo = TxtNombre.Text.Trim();
                oUs.Contrasennia = TxtContrasennia.Text.Trim();
                oUs.Codigo_Rol = this.Codigo_Rol;
                oUs.Telefono = TxtTelefono.Text.Trim();
                oUs.Direccion = TxtDireccion.Text.Trim();


                Rpta = N_Usuarios.Guadar_us(Estadoguarda, oUs);
                if (Rpta.Equals("OK"))
                {
                    this.Listado_us("%");
                    MessageBox.Show("Los datos han sido guardados correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Estadoguarda = 0; //Sin nunguna acción
                    this.Estado_Botonesprincipales(true);
                    this.Estado_Botonesprocesos(false);
                    this.Estado_texto(false);
                    TbpPrincipal.SelectedIndex = 0;
                    this.Codigo_Usuario = 0;
                    this.Codigo_Rol = 0;

                }
                else
                {
                    MessageBox.Show(Rpta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            this.Codigo_Rol = 0;
            this.Estado_texto(false);
            this.Limpia_texto();
            this.Estado_Botonesprincipales(true);
            this.Estado_Botonesprocesos(false);
            TbpPrincipal.SelectedIndex = 0;
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            Estadoguarda = 1; //Nuevo Registro           
            this.Estado_Botonesprincipales(false);
            this.Estado_Botonesprocesos(true);
            this.Limpia_texto();
            this.Estado_texto(true);
            TbpPrincipal.SelectedIndex = 1;
            TxtCedula.Focus();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            Estadoguarda = 2; //Actualizar Registro           
            this.Estado_Botonesprincipales(false);
            this.Estado_Botonesprocesos(true);
            this.Estado_texto(true);
            TbpPrincipal.SelectedIndex = 1;
            TxtCedula.Focus();
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

        private void BtnReporte_Click(object sender, EventArgs e)
        {

            Reportes.Frm_Rpt_Usuarios oRpt_us = new Reportes.Frm_Rpt_Usuarios();
            oRpt_us.txt_p1.Text = TxtBuscar.Text;
            oRpt_us.ShowDialog();
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

        private void BtnBuscarRol_Click(object sender, EventArgs e)
        {
            this.PnlRol.Location = BtnBuscarRol.Location;
            this.PnlRol.Visible = true;
        }

        private void BtnRetornar3_Click(object sender, EventArgs e)
        {
            PnlRol.Visible = false;
        }

        private void DgvRolUsuario_DoubleClick(object sender, EventArgs e)
        {
            this.Selecciona_rl_us();
            PnlRol.Visible = false;
        }
    }
}
