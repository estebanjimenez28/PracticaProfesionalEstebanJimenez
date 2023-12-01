using PracticaProfesional.Entidades;
using PracticaProfesional.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaProfesionalEstebanJimenez
{
    public partial class FrmClientes : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-HMNTIQK1\SQLEXPRESS;Initial Catalog=BD_PracticaProfesional;Integrated Security=True;");


        public FrmClientes()
        {
            InitializeComponent();
           
        }




        #region "Mis Variables"
        //Se declara e inicializa las variables del DataTable
        int Codigo_Cliente = 0;
        int Codigo_Identificacion = 0;
        int Estadoguarda = 0; //Sin ninguna acción
        #endregion

        #region "Mis Métodos"
        private void Formato_cl()
        {
            //Este metodo se crea para aplicar un formato expecifico sobre
            //la informacion que debe llevar el DataGridview Principal.
            DgvPrincipal.Columns[0].Width = 100;
            DgvPrincipal.Columns[0].HeaderText = "CÓDIGO";
            DgvPrincipal.Columns[1].Width = 150;
            DgvPrincipal.Columns[1].HeaderText = "TIPO";
            DgvPrincipal.Columns[2].Width = 150;
            DgvPrincipal.Columns[2].HeaderText = "CEDULA";
            DgvPrincipal.Columns[3].Width = 270;
            DgvPrincipal.Columns[3].HeaderText = "NOMBRE";
            DgvPrincipal.Columns[4].Width = 250;
            DgvPrincipal.Columns[4].HeaderText = "APELLIDOS";
            DgvPrincipal.Columns[5].Width = 210;
            DgvPrincipal.Columns[5].HeaderText = "RAZON SOCIAL";
            DgvPrincipal.Columns[6].Width = 250;
            DgvPrincipal.Columns[6].HeaderText = "CORREO";
            //Se procede a ocultar datos que no se desea que se presenten en el DataGridview
            DgvPrincipal.Columns[7].Visible = false;
            DgvPrincipal.Columns[8].Visible = false;
            DgvPrincipal.Columns[9].Visible = false;


        }

        private void Listado_cl(string cTexto)
        {
            //Este metodo se crea para cargar y mostrar los datos en el DataGridview
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

        public void cargar_datos()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Codigo_TipoIdentificacion,DescripcionIdentificacion FROM TipoIdentificacion", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            Cbx_Identificacion.ValueMember = "Codigo_TipoIdentificacion";
            Cbx_Identificacion.DisplayMember = "DescripcionIdentificacion";
            Cbx_Identificacion.DataSource = dt;

        }
        //Se procede a habilitar los botones en la Interfaz Grafica
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
            //Este proceso nos ayuda a controlar la visibilidad de los botones en un momento determinado
            this.BtnCancelar.Visible = lEstado;
            this.BtnGuardar.Visible = lEstado;
            this.BtnRetornar.Visible = !lEstado;
        }

        private void Selecciona_item()
        {
            //Este método se utiliza para seleccionar un elemento en el DataGridView (Dgv_principal)
            //y mostrar la información asociada en los textBox correspondientes de la interfaz de usuario
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
                Cbx_Identificacion.Text = Convert.ToString(DgvPrincipal.CurrentRow.Cells["DescripcionIdentificacion"].Value);
                TxtRazonSocial.Text = Convert.ToString(DgvPrincipal.CurrentRow.Cells["Razon_Social_Cliente"].Value);
                TxtEmail.Text = Convert.ToString(DgvPrincipal.CurrentRow.Cells["Correo"].Value);
                TxtTelefono.Text = Convert.ToString(DgvPrincipal.CurrentRow.Cells["Telefono"].Value);
                TxtDireccion.Text = Convert.ToString(DgvPrincipal.CurrentRow.Cells["Direccion"].Value);
                TxtObservacion.Text = Convert.ToString(DgvPrincipal.CurrentRow.Cells["Observacion"].Value).Trim();
               
            }

        }

    

   

  



        private void Estado_texto(bool lestado)
        {
            //Este metodo se encarga de cambiar el estado de lectura (read-only) de varios controles TextBox
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
            //Este metodo se encargara de limpiar el contenido de varios controles TextBox
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
            //Se carga la informacion en los formularios
            this.Listado_cl("%");
            this.cargar_datos();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtCedula.Text == String.Empty ||
              TxtNombre.Text == String.Empty ||
              TxtApellidos.Text == String.Empty ||
              TxtEmail.Text == String.Empty ||
              TxtTelefono.Text == String.Empty ||
              TxtDireccion.Text == String.Empty)
            {
                MessageBox.Show("Falta ingresar datos requeridos (*)", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else //Se procedería a registrar la información
            {
                string NumeroDocumento = TxtCedula.Text.Trim();
                bool agregar = true; // Asumimos que inicialmente está bien agregar el producto.

                foreach (DataGridViewRow fila in DgvPrincipal.Rows)
                {
                    if (fila.Cells["NumeroDocumento_Cliente"].Value != null &&
                        fila.Cells["NumeroDocumento_Cliente"].Value.ToString().Trim().Equals(NumeroDocumento, StringComparison.OrdinalIgnoreCase))
                    {
                        agregar = false;
                        MessageBox.Show("El cliente con esta cedula ya se encuentra agregado en el sistema", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break; // No es necesario seguir verificando si ya se encontró una coincidencia.
                    }
                }

                if (agregar)
                {

                    string Rpta = "";
                    E_Clientes oCl = new E_Clientes();

                    // Obtener el valor seleccionado del ComboBox y asignarlo al objeto oCl
                    if (Cbx_Identificacion.SelectedItem != null)
                    {
                        // Aquí asumimos que la propiedad "Value" del ComboBox contiene el código del tipo de identificación.
                        oCl.Codigo_TipoIdentificacion = Convert.ToInt32(Cbx_Identificacion.SelectedValue);
                    }

                    oCl.Codigo_Cliente = this.Codigo_Cliente;
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
                        this.Estado_texto(true);
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
        TxtNombre.Text == String.Empty ||
        TxtApellidos.Text == String.Empty ||
        TxtEmail.Text == String.Empty ||
        TxtTelefono.Text == String.Empty ||
        TxtDireccion.Text == String.Empty)
            {
                MessageBox.Show("Falta ingresar datos requeridos (*)", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else // Se procedería a modificar la información
            {
                string NumeroDocumento = TxtCedula.Text.Trim();
                bool modificar = false; // Asumimos que inicialmente no está permitido modificar el cliente.

                foreach (DataGridViewRow fila in DgvPrincipal.Rows)
                {
                    if (fila.Cells["NumeroDocumento_Cliente"].Value != null &&
                        fila.Cells["NumeroDocumento_Cliente"].Value.ToString().Trim().Equals(NumeroDocumento, StringComparison.OrdinalIgnoreCase))
                    {
                        modificar = true;
                        break; // No es necesario seguir verificando si ya se encontró una coincidencia.
                    }
                }

                if (modificar)
                {
                    string Rpta = "";
                    E_Clientes oCl = new E_Clientes();

                    // Obtener el valor seleccionado del ComboBox y asignarlo al objeto oCl
                    if (Cbx_Identificacion.SelectedItem != null)
                    {
                        // Aquí asumimos que la propiedad "Value" del ComboBox contiene el código del tipo de identificación.
                        oCl.Codigo_TipoIdentificacion = Convert.ToInt32(Cbx_Identificacion.SelectedValue);
                    }

                    oCl.Codigo_Cliente = this.Codigo_Cliente; // Asegúrate de tener el código del cliente que deseas modificar.
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
                        MessageBox.Show("Los datos han sido modificados correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Estadoguarda = 0; // Sin ninguna acción
                        this.Estado_Botonesprincipales(true);
                        this.Estado_Botonesprocesos(false);
                        this.Estado_texto(true);
                        TbpPrincipal.SelectedIndex = 0;
                        this.Codigo_Cliente = 0;
                        this.Codigo_Identificacion = 0;
                    }
                    else
                    {
                        MessageBox.Show(Rpta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El cliente no se encuentra en el sistema. No es posible modificar.", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            //Este código está diseñado para permitir al usuario eliminar (anular) un registro de entrada.
            //Realiza la eliminación en la capa de negocio y actualiza la interfaz de usuario
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
            //Se crea una instancia del formulario de reporte
            Reportes.Frm_Rpt_Clientes oRpt_cl = new Reportes.Frm_Rpt_Clientes();
            oRpt_cl.txt_p1.Text = TxtBuscar.Text;
            oRpt_cl.ShowDialog();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            //Se cierra el formulario
            this.Close();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            //Se filtra la informacion del dataGridview Principal
            this.Listado_cl(TxtBuscar.Text.Trim());
        }

        private void DgvPrincipal_DoubleClick(object sender, EventArgs e)
        {
            //Al dar doble clik la informacion se muestra en el textBox
            this.Selecciona_item();
            this.Estado_Botonesprocesos(false);
            TbpPrincipal.SelectedIndex = 1;
        }

        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresNumeros(e, true);
        }

        private void TxtRazonSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresNumeros(e, true);
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
