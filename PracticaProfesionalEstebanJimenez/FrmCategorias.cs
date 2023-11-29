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
        //Se declara e inicializa las variables del DataTable
        int Codigo_Categoria = 0;

        int Estadoguarda = 0; //Sin alguna accion

        #endregion

        


        #region "Mis Metodos"
        private void Formato_ca()
        {
            //Este metodo se crea para aplicar un formato expecifico sobre
            //la informacion que debe llevar el DataGridview Principal.
            DgvPrincipal.Columns[0].Width = 250;
            DgvPrincipal.Columns[0].HeaderText = "CÓDIGO";
            DgvPrincipal.Columns[1].Width = 650;
            DgvPrincipal.Columns[1].HeaderText = "CATEGORÍA";
        }

        private void Listado_ca(string cTexto)
        {
            //Este metodo se crea para cargar y mostrar los datos en el DataGridview
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
            if (string.IsNullOrEmpty(Convert.ToString(DgvPrincipal.CurrentRow.Cells["Codigo_Categoria"].Value)))
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
            //Se carga la informacion en los formularios
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
            //Se establece el estado de guardado en 1, indicando que se está creando un nuevo registro
            Estadoguarda = 1; //Nuevo Registro

            //Desactiva los botones principales.
            this.Estado_BotonesPrincipales(false);
            // Activa los botones de procesos.
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
            // Se restablece el código a cero.
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
            //Al seleccionar 2 veces la informacion en el Dgv esta se mostrara en el textBox Correspondiente
            this.Selecciona_item();
            this.Estado_Botonesprocesos(false);
            TbpPrincipal.SelectedIndex = 1;
        }

        private void BtnRetornar_Click(object sender, EventArgs e)
        {
            //Regresa al formulario principal
            this.Estado_Botonesprocesos(false);
            TbpPrincipal.SelectedIndex = 0;
            this.Codigo_Categoria = 0;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            //Este código está diseñado para permitir al usuario eliminar (anular) un registro de entrada.
            //Realiza la eliminación en la capa de negocio y actualiza la interfaz de usuario
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

            //Se filtra la informacion del dataGridview Principal
            this.Listado_ca(TxtBuscar.Text.Trim());
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            //Se crea una instancia del formulario de reporte
            Reportes.Frm_Rpt_Categorias oRpt1 = new Reportes.Frm_Rpt_Categorias();
            oRpt1.txt_p1.Text = TxtBuscar.Text;
            oRpt1.ShowDialog();
        }


        private void BtnSalir_Click(object sender, EventArgs e)
        {
            //Se cierra el formulario
            this.Close();
        }
    }
}
