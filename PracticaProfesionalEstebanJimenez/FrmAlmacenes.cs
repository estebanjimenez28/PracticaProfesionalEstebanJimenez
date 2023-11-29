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
        //Se declara e inicializa las variables del DataTable
        int Codigo_Almacen = 0;
        int Estadoguarda = 0; //Sin alguna accion

        #endregion




        #region "Mis Metodos"
        private void Formato_al()
        {
            //Este metodo se crea para aplicar un formato expecifico sobre
            //la informacion que debe llevar el DataGridview Principal.
            DgvPrincipal.Columns[0].Width = 250;
            DgvPrincipal.Columns[0].HeaderText = "CÓDIGO";
            DgvPrincipal.Columns[1].Width = 650;
            DgvPrincipal.Columns[1].HeaderText = "ALMACÉN";
        }

        private void Listado_al(string cTexto)
        {
            //Este metodo se crea para cargar y mostrar los datos en el DataGridview
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
            //Se carga la informacion en los formularios
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
            //Se establece el estado de guardado en 1, indicando que se está creando un nuevo registro
            Estadoguarda = 1; //Nuevo Registro

            //Desactiva los botones principales.
            this.Estado_BotonesPrincipales(false);
            // Activa los botones de procesos.
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
            // Se restablece el código a cero.
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
            this.Codigo_Almacen = 0;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            //Este código está diseñado para permitir al usuario eliminar (anular) un registro de entrada.
            //Realiza la eliminación en la capa de negocio y actualiza la interfaz de usuario
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
            //Se filtra la informacion del dataGridview Principal
            this.Listado_al(TxtBuscar.Text.Trim());
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            //Se crea una instancia del formulario de reporte
            Reportes.Frm_Rpt_Almacenes oRpt3 = new Reportes.Frm_Rpt_Almacenes();
            oRpt3.txt_p1.Text = TxtBuscar.Text;
            oRpt3.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Se cierra el formulario
            this.Close();
        }
    }
}
