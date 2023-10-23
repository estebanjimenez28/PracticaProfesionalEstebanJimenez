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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }
        #region "Mis Variables"
        int Codigo_Cliente = 0;
        int Codigo_Identificacion = 0;
        int Estadoguarda = 0; //Sin ninguna acción
        #endregion

        #region "Mis Métodos"
        private void Formato_cl()
        {
            DgvPrincipal.Columns[0].Width = 85;
            DgvPrincipal.Columns[0].HeaderText = "CÓDIGO";
            DgvPrincipal.Columns[1].Width = 85;
            DgvPrincipal.Columns[1].HeaderText = "TIPO";
            DgvPrincipal.Columns[2].Width = 110;
            DgvPrincipal.Columns[2].HeaderText = "CEDULA";
            DgvPrincipal.Columns[3].Width = 270;
            DgvPrincipal.Columns[3].HeaderText = "NOMBRE";
            DgvPrincipal.Columns[4].Width = 150;
            DgvPrincipal.Columns[4].HeaderText = "APELLIDOS";
            DgvPrincipal.Columns[5].Width = 150;
            DgvPrincipal.Columns[5].HeaderText = "RAZON SOCIAL";
            DgvPrincipal.Columns[6].Width = 200;
            DgvPrincipal.Columns[6].HeaderText = "CORREO";
            DgvPrincipal.Columns[7].Visible = false;
    

        }

        private void Listado_cl(string cTexto)
        {
            try
            {
                DgvPrincipal.DataSource = N_Clientes.Listado_cl(cTexto);
                this.Formato_cl();
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
            if (string.IsNullOrEmpty(Convert.ToString(DgvPrincipal.CurrentRow.Cells["Codigo_Cliente"].Value)))
            {
                MessageBox.Show("No se tiene información para Visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                this.Codigo_Cliente = Convert.ToInt32(DgvPrincipal.CurrentRow.Cells["Codigo_Cliente"].Value);
                TxtCedula.Text = Convert.ToString(DgvPrincipal.CurrentRow.Cells["NumeroDocumento_Cliente"].Value);
                TxtNombre.Text = Convert.ToString(DgvPrincipal.CurrentRow.Cells["Nombre"].Value);
                TxtApellidos.Text = Convert.ToString(DgvPrincipal.CurrentRow.Cells["Apellidos"].Value);
                TxtRazonSocial.Text = Convert.ToString(DgvPrincipal.CurrentRow.Cells["Razon_Social_Cliente"].Value);
                TxtEmail.Text = Convert.ToString(DgvPrincipal.CurrentRow.Cells["Correo"].Value);
                TxtTelefono.Text = Convert.ToString(DgvPrincipal.CurrentRow.Cells["Telefono"].Value);
                TxtDireccion.Text = Convert.ToString(DgvPrincipal.CurrentRow.Cells["Direccion"].Value);
                TxtObservacion.Text = Convert.ToString(DgvPrincipal.CurrentRow.Cells["Observacion"].Value).Trim();
                TxtTipoIdentificacion.Text = Convert.ToString(DgvPrincipal.CurrentRow.Cells["DescripcionIdentificacion"].Value);
            }

        }

        private void Formato_TipoIdentificacion_cl()
        {
            DgvIdentificacion.Columns[0].Width = 300;
            DgvIdentificacion.Columns[0].HeaderText = "TIPO IDENTIFICACION";
            DgvIdentificacion.Columns[1].Visible = false;

        }

        private void Listado_TipoIdentificacion_cl(string cTexto)
        {
            try
            {
                DgvIdentificacion.DataSource = N_Clientes.Listado_TipoIdentificacion_cl(cTexto);
                this.Formato_TipoIdentificacion_cl();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Selecciona_TipoIdentificacion_cl()
        {
            if (string.IsNullOrEmpty(Convert.ToString(DgvIdentificacion.CurrentRow.Cells["Codigo_TipoIdentificacion"].Value)))
            {
                MessageBox.Show("No se tiene información para Visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Codigo_Identificacion = Convert.ToInt32(DgvIdentificacion.CurrentRow.Cells["Codigo_TipoIdentificacion"].Value);
                TxtTipoIdentificacion.Text = Convert.ToString(DgvIdentificacion.CurrentRow.Cells["DescripcionIdentificacion"].Value);
            }
        }



        private void Estado_texto(bool lestado)
        {
            TxtCedula.ReadOnly = !lestado;
            TxtNombre.ReadOnly = !lestado;
            TxtApellidos.ReadOnly = !lestado;
            TxtEmail.ReadOnly = !lestado;
            TxtTelefono.ReadOnly = !lestado;
            TxtDireccion.ReadOnly = !lestado;
            TxtObservacion.ReadOnly = !lestado;
        }

        private void Limpia_texto()
        {
            TxtCedula.Text = "";
            TxtNombre.Text = "";
            TxtApellidos.Text = "";
            TxtEmail.Text = "";
            TxtTelefono.Text = "";
            TxtDireccion.Text = "";
            TxtObservacion.Text = "";
        }
        #endregion

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            this.Listado_cl("%");
            this.Listado_TipoIdentificacion_cl("%");
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtCedula.Text == String.Empty ||
              TxtTipoIdentificacion.Text == String.Empty ||
              TxtNombre.Text == String.Empty ||
              TxtApellidos.Text == String.Empty ||
              TxtEmail.Text == String.Empty ||
              TxtTelefono.Text == String.Empty ||
              TxtDireccion.Text == String.Empty)
            {
                MessageBox.Show("Falta ingresa datos requeridos (*)", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else //Se procedería a registrar la información
            {

                string Rpta = "";
                E_Clientes oCl = new E_Clientes();

                oCl.Codigo_Cliente = this.Codigo_Cliente;
                oCl.Codigo_TipoIdentificacion = this.Codigo_Identificacion;
                oCl.NumeroDocumento = TxtCedula.Text.Trim();
                oCl.Nombre = TxtNombre.Text.Trim();
                oCl.Apellidos = TxtApellidos.Text.Trim();
                oCl.RazonSocial_Cliente = TxtRazonSocial.Text.Trim();
                oCl.Correo = TxtEmail.Text.Trim();
                oCl.Telefono = TxtTelefono.Text.Trim();
                oCl.Direccion = TxtDireccion.Text.Trim();
                oCl.Observacion = TxtObservacion.Text.Trim();


                Rpta = N_Clientes.Guadar_cl(Estadoguarda, oCl);
                if (Rpta.Equals("OK"))
                {
                    this.Listado_cl("%");
                    MessageBox.Show("Los datos han sido guardados correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Estadoguarda = 0; //Sin nunguna acción
                    this.Estado_Botonesprincipales(true);
                    this.Estado_Botonesprocesos(false);
                    this.Estado_texto(false);
                    TbpPrincipal.SelectedIndex = 0;
                    this.Codigo_Cliente = 0;
                    this.Codigo_Identificacion = 0;


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
            Estadoguarda = 0; //Sin ninguna acción

            this.Codigo_Cliente = 0;
            this.Codigo_Identificacion = 0;
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
            if (string.IsNullOrEmpty(Convert.ToString(DgvPrincipal.CurrentRow.Cells["Codigo_Cliente"].Value)))
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
                    this.Codigo_Cliente = Convert.ToInt32(DgvPrincipal.CurrentRow.Cells["Codigo_Cliente"].Value);
                    Rpta = N_Clientes.Eliminar_cl(this.Codigo_Cliente);
                    if (Rpta.Equals("OK"))
                    {
                        this.Listado_cl("%");
                        this.Codigo_Cliente = 0;
                        MessageBox.Show("Registro Eliminado", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }



            }
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            Reportes.Frm_Rpt_Clientes oRpt_cl = new Reportes.Frm_Rpt_Clientes();
            oRpt_cl.txt_p1.Text = TxtBuscar.Text;
            oRpt_cl.ShowDialog();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.Listado_cl(TxtBuscar.Text.Trim());
        }

        private void DgvPrincipal_DoubleClick(object sender, EventArgs e)
        {
            this.Selecciona_item();
            this.Estado_Botonesprocesos(false);
            TbpPrincipal.SelectedIndex = 1;
        }

        private void BtnBuscarIdentificacion_Click(object sender, EventArgs e)
        {
            this.PnlIdentificacion.Location = BtnBuscarIdentificacion.Location;
            this.PnlIdentificacion.Visible = true;
        }

        private void BtnRetornar3_Click(object sender, EventArgs e)
        {
            PnlIdentificacion.Visible = false;
        }

        private void DgvIdentificacion_DoubleClick(object sender, EventArgs e)
        {
            this.Selecciona_TipoIdentificacion_cl();
            PnlIdentificacion.Visible = false;
        }
    }
}
