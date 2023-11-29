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
using PracticaProfesional.Negocio;

namespace PracticaProfesionalEstebanJimenez
{
    public partial class Frm_Registro : Form
    {
        public Frm_Registro()
        {
            InitializeComponent();
        }

        #region "Mis Metodos"
        private void Login_us(string cLogin, string cContrasennia)
        {
            try
            {
                //Se declara y inicializa una variable DataTable llamada data_login.
                DataTable data_login = new DataTable();
                //Luego, se llama a un método Login_us de la clase N_Usuarios (supongo que es una clase que maneja operaciones relacionadas con usuarios)
                //y se le pasa el nombre de usuario (cLogin) y la contraseña (cContrasennia).
                data_login = N_Usuarios.Login_us(cLogin, cContrasennia);
                //Se verifica si hay al menos una fila en el resultado (data_login.Rows.Count > 0),
                //lo que indica que las credenciales son válidas y se encontró al menos un usuario.
                if (data_login.Rows.Count>0)
                {
                    string cNombre="";
                    string cCargo = "";
                    bool bAdmin = false;


                    cNombre =Convert.ToString( data_login.Rows[0][3]);
                    cCargo= Convert.ToString(data_login.Rows[0][4]);
                    bAdmin = Convert.ToBoolean(data_login.Rows[0][5]);

                    MDI_Principal oMDI = new MDI_Principal();
                    oMDI.lblnombreusuario.Text = "Nombre:" + cNombre;
                    oMDI.lblcargo.Text = "Cargo:" + cCargo;
                    oMDI.ChkAdmin.Checked = bAdmin;

                    if(bAdmin==true)//Administrador
                    {
                        oMDI.BtnProcesos.Enabled = true;
                        oMDI.BtnReportes.Enabled = true;
                        oMDI.BtnGestiones.Enabled = true;
                        oMDI.BtnSistemas.Enabled = true;
                    }
                    else
                    {
                        oMDI.BtnProcesos.Enabled = true;
                        oMDI.BtnReportes.Enabled = true;
                        oMDI.BtnGestiones.Enabled = true;
                        oMDI.BtnSistemas.Enabled = false;

                    }


                    oMDI.Show();
                   oMDI.FormClosed += Logout;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Acceso Denegado", "Aviso del Sistema");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Logout(object sender,FormClosedEventArgs e)
        {
            TxtUsuario.Text = "";
            TxtContrasennia.Text = "";
            this.Show();    
            TxtUsuario.Focus(); 
        }
        #endregion

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            this.Login_us(TxtUsuario.Text, TxtContrasennia.Text);

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void Frm_Registro_Load(object sender, EventArgs e)
        {

        }

        private void BtnMostrar_MouseDown(object sender, MouseEventArgs e)
        {
            TxtContrasennia.UseSystemPasswordChar = false;
        }

        private void BtnMostrar_MouseUp(object sender, MouseEventArgs e)
        {
            TxtContrasennia.UseSystemPasswordChar = true;
        }
    }
}
