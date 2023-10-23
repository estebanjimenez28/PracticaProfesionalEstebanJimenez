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
    public partial class FrmProveedores : Form
    {
        public FrmProveedores()
        {
            InitializeComponent();
        }

        #region "Mis Variables"
        int Codigo_Proveedor = 0;
        int Codigo_Producto = 0;
        int Estadoguarda = 0; //Sin ninguna acción
        #endregion

        #region "Mis Métodos"
        private void Formato_pv()
        {
            DgvPrincipal.Columns[0].Width = 85;
            DgvPrincipal.Columns[0].HeaderText = "CÓDIGO";
            DgvPrincipal.Columns[1].Width = 110;
            DgvPrincipal.Columns[1].HeaderText = "CEDULA";
            DgvPrincipal.Columns[2].Width = 270;
            DgvPrincipal.Columns[2].HeaderText = "RAZON SOCIAL";
            DgvPrincipal.Columns[3].Width = 150;
            DgvPrincipal.Columns[3].HeaderText = "NOMBRE";
            DgvPrincipal.Columns[4].Width = 150;
            DgvPrincipal.Columns[4].HeaderText = "APELLIDOS";
            DgvPrincipal.Columns[5].Width = 200;
            DgvPrincipal.Columns[5].HeaderText = "PRODUCTO";
            DgvPrincipal.Columns[6].Visible = false;
            DgvPrincipal.Columns[7].Visible = false;
            DgvPrincipal.Columns[8].Visible = false;
            DgvPrincipal.Columns[9].Visible = false;
     




        }

        private void Listado_pv(string cTexto)
        {
            try
            {
                DgvPrincipal.DataSource = N_Proveedores.Listado_pv(cTexto);
                this.Formato_pv();
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
            if (string.IsNullOrEmpty(Convert.ToString(DgvPrincipal.CurrentRow.Cells["Codigo_Proveedor"].Value)))
            {
                MessageBox.Show("No se tiene información para Visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
              
                this.Codigo_Proveedor = Convert.ToInt32(DgvPrincipal.CurrentRow.Cells["Codigo_Proveedor"].Value);
                TxtCedula.Text = Convert.ToString(DgvPrincipal.CurrentRow.Cells["Cedula_Proveedor"].Value);
                TxtRazonSocial.Text = Convert.ToString(DgvPrincipal.CurrentRow.Cells["Razon_Social"].Value);
                TxtNombre.Text = Convert.ToString(DgvPrincipal.CurrentRow.Cells["Nombre"].Value);
                TxtApellidos.Text = Convert.ToString(DgvPrincipal.CurrentRow.Cells["Apellidos"].Value);
                TxtProducto.Text = Convert.ToString(DgvPrincipal.CurrentRow.Cells["Descripcion_Producto"].Value);
                TxtEmail.Text = Convert.ToString(DgvPrincipal.CurrentRow.Cells["Correo"].Value);
                TxtTelefono.Text = Convert.ToString(DgvPrincipal.CurrentRow.Cells["Telefono"].Value);
                TxtDireccion.Text = Convert.ToString(DgvPrincipal.CurrentRow.Cells["Direccion"].Value);
                TxtObservacion.Text = Convert.ToString(DgvPrincipal.CurrentRow.Cells["Observacion"].Value).Trim();
            }

        }



        private void Formato_pr_pv()
        {
            DgvProductoProveedor.Columns[0].Width = 300;
            DgvProductoProveedor.Columns[0].HeaderText = "PRODUCTOS";
            DgvProductoProveedor.Columns[1].Visible = false;

        }

        private void Listado_pr_pv(string cTexto)
        {
            try
            {
               DgvProductoProveedor.DataSource = N_Proveedores.Listado_pr_pv(cTexto);
               this.Formato_pr_pv();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Selecciona_pr_pv()
        {
            if (string.IsNullOrEmpty(Convert.ToString(DgvProductoProveedor.CurrentRow.Cells["Codigo_Producto"].Value)))
            {
              MessageBox.Show("No se tiene información para Visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
             this.Codigo_Producto = Convert.ToInt32(DgvProductoProveedor.CurrentRow.Cells["Codigo_Producto"].Value);
            TxtProducto.Text = Convert.ToString(DgvProductoProveedor.CurrentRow.Cells["Descripcion_Producto"].Value);
            }
        }

      
        private void Estado_texto(bool lestado)
        {
            TxtCedula.ReadOnly = !lestado;
            TxtRazonSocial.ReadOnly = !lestado;
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
            TxtRazonSocial.Text = "";
            TxtNombre.Text = "";
            TxtApellidos.Text = "";
            TxtEmail.Text = "";
            TxtTelefono.Text = "";
            TxtDireccion.Text = "";
            TxtObservacion.Text = "";
        }
        #endregion

   
    
     

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            this.Listado_pv("%");
            this.Listado_pr_pv("%");
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtCedula.Text == String.Empty ||
               TxtProducto.Text == String.Empty ||
               TxtRazonSocial.Text == String.Empty ||
               TxtDireccion.Text == String.Empty)
            {
                MessageBox.Show("Falta ingresa datos requeridos (*)", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else //Se procedería a registrar la información
            {

                string Rpta = "";
                E_Proveedores oPv = new E_Proveedores();

                oPv.Codigo_Proveedor = this.Codigo_Proveedor;
                oPv.Cedula = TxtCedula.Text.Trim();
                oPv.RazonSocial = TxtRazonSocial.Text.Trim();
                oPv.Nombre = TxtNombre.Text.Trim();
                oPv.Apellidos = TxtApellidos.Text.Trim();
                oPv.Codigo_Producto = this.Codigo_Producto;
                oPv.Correo = TxtEmail.Text.Trim();
                oPv.Telefono = TxtTelefono.Text.Trim();
                oPv.Direccion = TxtDireccion.Text.Trim();
                oPv.Observacion = TxtObservacion.Text.Trim();


                Rpta = N_Proveedores.Guadar_pv(Estadoguarda, oPv);
                if (Rpta.Equals("OK"))
                {
                    this.Listado_pv("%");
                    MessageBox.Show("Los datos han sido guardados correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Estadoguarda = 0; //Sin nunguna acción
                    this.Estado_Botonesprincipales(true);
                    this.Estado_Botonesprocesos(false);
                    this.Estado_texto(false);
                    TbpPrincipal.SelectedIndex = 0;
                    this.Codigo_Proveedor = 0;
                    this.Codigo_Producto = 0;

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

            this.Codigo_Proveedor = 0;
            this.Codigo_Producto = 0;
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
            if (string.IsNullOrEmpty(Convert.ToString(DgvPrincipal.CurrentRow.Cells["Codigo_Proveedor"].Value)))
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
                    this.Codigo_Proveedor = Convert.ToInt32(DgvPrincipal.CurrentRow.Cells["Codigo_Proveedor"].Value);
                    Rpta = N_Proveedores.Eliminar_pv(this.Codigo_Proveedor);
                    if (Rpta.Equals("OK"))
                    {
                        this.Listado_pv("%");
                        this.Codigo_Proveedor = 0;
                        MessageBox.Show("Registro Eliminado", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }



            }
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            Reportes.Frm_Rpt_Proveedores oRpt_pv = new Reportes.Frm_Rpt_Proveedores();
            oRpt_pv.txt_p1.Text = TxtBuscar.Text;
            oRpt_pv.ShowDialog();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.Listado_pv(TxtBuscar.Text.Trim());
        }

        private void DgvPrincipal_DoubleClick(object sender, EventArgs e)
        {
            this.Selecciona_item();
            this.Estado_Botonesprocesos(false);
            TbpPrincipal.SelectedIndex = 1;
        }




        private void Btn_lupa2_Click_1(object sender, EventArgs e)
        {
            this.PnlProductos.Location = Btn_lupa2.Location;
            this.PnlProductos.Visible = true;
        }

        private void BtnRetornar3_Click(object sender, EventArgs e)
        {
            PnlProductos.Visible = false;
        }

        private void BtnBuscar3_Click(object sender, EventArgs e)
        {
            this.Listado_pr_pv(TxtBuscar3.Text);
        }

        private void DgvProductoProveedor_DoubleClick(object sender, EventArgs e)
        {
            this.Selecciona_pr_pv();
            PnlProductos.Visible = false;
        }
    }
}