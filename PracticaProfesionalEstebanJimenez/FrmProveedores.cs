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
        //Se declara e inicializa las variables del DataTable
        int Codigo_Proveedor = 0;
        int Codigo_Producto = 0;
        int Estadoguarda = 0; //Sin ninguna acción
        #endregion

        #region "Mis Métodos"
        private void Formato_pv()
        {
            //Este metodo se crea para aplicar un formato expecifico sobre
            //la informacion que debe llevar el DataGridview Principal.
            DgvPrincipal.Columns[0].Width = 130;
            DgvPrincipal.Columns[0].HeaderText = "CÓDIGO";
            DgvPrincipal.Columns[1].Width = 210;
            DgvPrincipal.Columns[1].HeaderText = "CEDULA";
            DgvPrincipal.Columns[2].Width = 300;
            DgvPrincipal.Columns[2].HeaderText = "RAZON SOCIAL";
            DgvPrincipal.Columns[3].Width = 250;
            DgvPrincipal.Columns[3].HeaderText = "NOMBRE";
            DgvPrincipal.Columns[4].Width = 230;
            DgvPrincipal.Columns[4].HeaderText = "APELLIDOS";
            DgvPrincipal.Columns[5].Width = 230;
            DgvPrincipal.Columns[5].HeaderText = "PRODUCTO";
            //Se procede a ocultar datos que no se desea que se presenten en el DataGridview
            DgvPrincipal.Columns[6].Visible = false;
            DgvPrincipal.Columns[7].Visible = false;
            DgvPrincipal.Columns[8].Visible = false;
            DgvPrincipal.Columns[9].Visible = false;
     




        }

        private void Listado_pv(string cTexto)
        {
            //Este metodo se crea para cargar y mostrar los datos en el DataGridview
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
            //Se procede a habilitar los botones en la Interfaz Grafica
            this.BtnNuevo.Enabled = lEstado;
            this.BtnActualizar.Enabled = lEstado;
            this.BtnEliminar.Enabled = lEstado;
            this.BtnReporte.Enabled = lEstado;
            this.BtnSalir.Enabled = lEstado;
        }

        private void Estado_Botonesprocesos(bool lEstado)
        {
            //Este proceso nos ayuda a controlar la visibilidad de los botones en un momento determinado
            this.BtnCancelar.Visible = lEstado;
            this.BtnGuardar.Visible = lEstado;
            this.BtnRetornar.Visible = !lEstado;
        }

        private void Selecciona_item()
        {
            //Este método se utiliza para seleccionar un elemento en el DataGridView (Dgv_principal)
            //y mostrar la información asociada en los textBox correspondientes de la interfaz de usuario
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
            //Se aplica un formato al datagridview de Productos
            DgvProductoProveedor.Columns[0].Width = 620;
            DgvProductoProveedor.Columns[0].HeaderText = "PRODUCTOS";
            DgvProductoProveedor.Columns[1].Visible = false;

        }

        private void Listado_pr_pv(string cTexto)
        {
            //Se procede a cargar y listar la informacion en el datagridview
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
            //Este metodo funcina para seleccionar la informacion del datagriview y mostrarla en los textbox correspondientes
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
            //Este metodo se encarga de cambiar el estado de lectura (read-only) de varios controles TextBox
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
            //Este metodo se encargara de limpiar el contenido de varios controles TextBox
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
            //Se carga la informacion en los formularios
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
                string NumeroDocumento = TxtCedula.Text.Trim();
                bool agregar = true; // Asumimos que inicialmente está bien agregar el producto.

                foreach (DataGridViewRow fila in DgvPrincipal.Rows)
                {
                    if (fila.Cells["Cedula_Proveedor"].Value != null &&
                        fila.Cells["Cedula_Proveedor"].Value.ToString().Trim().Equals(NumeroDocumento, StringComparison.OrdinalIgnoreCase))
                    {
                        agregar = false;
                        MessageBox.Show("El Proveedor con esta cedula ya se encuentra agregado en el sistema", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break; // No es necesario seguir verificando si ya se encontró una coincidencia.
                    }
                }


                if (agregar)
                {
                    string Rpta = "";
                    E_Proveedores oPv = new E_Proveedores();
                    // Obtener el valor seleccionado del ComboBox y asignarlo al objeto oCl


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
                        this.Estado_texto(true);
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
        }
        

        private void BtnRetornar_Click(object sender, EventArgs e)
        {
            //Regresa al formulario Principal
            this.Estado_Botonesprocesos(false);
            TbpPrincipal.SelectedIndex = 0;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            // Se restablece el código a cero.
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
            //Se establece el estado de guardado en 1, indicando que se está creando un nuevo registro
            Estadoguarda = 1; //Nuevo Registro
                              //Desactiva los botones principales.
            this.Estado_Botonesprincipales(false);
            // Activa los botones de procesos.
            this.Estado_Botonesprocesos(true);
            this.Limpia_texto();
            this.Estado_texto(true);
            TbpPrincipal.SelectedIndex = 1;
            TxtCedula.Focus();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (TxtCedula.Text == String.Empty ||
         TxtProducto.Text == String.Empty ||
         TxtRazonSocial.Text == String.Empty ||
         TxtDireccion.Text == String.Empty)
            {
                MessageBox.Show("Falta ingresar datos requeridos (*)", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else // Se procedería a modificar la información
            {
                string NumeroDocumento = TxtCedula.Text.Trim();
                bool modificar = false; // Asumimos que inicialmente no está permitido modificar el proveedor.

                foreach (DataGridViewRow fila in DgvPrincipal.Rows)
                {
                    if (fila.Cells["Cedula_Proveedor"].Value != null &&
                        fila.Cells["Cedula_Proveedor"].Value.ToString().Trim().Equals(NumeroDocumento, StringComparison.OrdinalIgnoreCase))
                    {
                        modificar = true;
                        break; // No es necesario seguir verificando si ya se encontró una coincidencia.
                    }
                }

                if (modificar)
                {
                    string Rpta = "";
                    E_Proveedores oPv = new E_Proveedores();

                    // Obtener el valor seleccionado del ComboBox y asignarlo al objeto oPv
                    // Puedes modificar esto según la estructura de tu ComboBox y la lógica necesaria.
                    // oPv.Codigo_TipoIdentificacion = ...

                    oPv.Codigo_Proveedor = this.Codigo_Proveedor; // Asegúrate de tener el código del proveedor que deseas modificar.
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
                        MessageBox.Show("Los datos han sido modificados correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Estadoguarda = 0; // Sin ninguna acción
                        this.Estado_Botonesprincipales(true);
                        this.Estado_Botonesprocesos(false);
                        this.Estado_texto(true);
                        TbpPrincipal.SelectedIndex = 0;
                        this.Codigo_Proveedor = 0;
                        this.Codigo_Producto = 0;
                    }
                    else
                    {
                        MessageBox.Show(Rpta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El proveedor no se encuentra en el sistema. No es posible modificar.", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            //Este código está diseñado para permitir al usuario eliminar (anular) un registro de entrada.
            //Realiza la eliminación en la capa de negocio y actualiza la interfaz de usuario
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
            //Se crea una instancia del formulario de reporte
            Reportes.Frm_Rpt_Proveedores oRpt_pv = new Reportes.Frm_Rpt_Proveedores();
            oRpt_pv.txt_p1.Text = TxtBuscar.Text;
            oRpt_pv.ShowDialog();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            //Se cierra el formulario
            this.Close();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            //Se filtra la informacion del dataGridview Principal
            this.Listado_pv(TxtBuscar.Text.Trim());
        }

        private void DgvPrincipal_DoubleClick(object sender, EventArgs e)
        {
            //Al dar doble clik la informacion se muestra en el textBox
            this.Selecciona_item();
            this.Estado_Botonesprocesos(false);
            TbpPrincipal.SelectedIndex = 1;
        }




        private void Btn_lupa2_Click_1(object sender, EventArgs e)
        {
            //Se despliega el formulario de Lista de Productos
            this.PnlProductos.Location = TxtCedula.Location;
            this.PnlProductos.Visible = true;
        }

        private void BtnRetornar3_Click(object sender, EventArgs e)
        {
            //Se oculta el formulario de Productos
            PnlProductos.Visible = false;
        }

        private void BtnBuscar3_Click(object sender, EventArgs e)
        {
            //Se filtra la informacion del dataGridview Productos
            this.Listado_pr_pv(TxtBuscar3.Text);
        }

        private void DgvProductoProveedor_DoubleClick(object sender, EventArgs e)
        {
            //Al dar doble clik la informacion se muestra en el textBox
            this.Selecciona_pr_pv();
            PnlProductos.Visible = false;
        }

        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresNumeros(e, true);
        }

        private void TxtRazonSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, true);
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, true);
        }

        private void TxtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, true);
        }

        private void TxtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, false, true);
        }

        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtEmail.Text.Trim()))
            {
                if (Validaciones.ValidarEmail(TxtEmail.Text.Trim()))
                {
                    MessageBox.Show("El formato del correo electronico es incorrecto", "Error de Validacion", MessageBoxButtons.OK);
                    TxtEmail.Focus();
                }
            }
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e);
        }

        private void TxtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, true);
        }

        private void TxtObservacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, true);
        }
    }
}