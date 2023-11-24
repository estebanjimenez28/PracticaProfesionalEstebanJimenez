using PracticaProfesional.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaProfesional.Datos
{
    public class D_Usuarios
    {
        //En la clase datos se procede a llamar los diferentes procedimientos almacenados
        //que se encargaran de realizar las funciones dentro de los formularios, como por ejemplo,
        //listar, guardar y eliminar
        public DataTable Listado_us(string cTexto)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SQLCon = new SqlConnection();

            try
            {
                SQLCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Listado_us", SQLCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@cTexto", SqlDbType.VarChar).Value = cTexto;
                SQLCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (SQLCon.State == ConnectionState.Open) SQLCon.Close();
            }
        }
        public string Guardar_us(int nOpcion, E_Usuarios oUs)
        {
            //Se crea un objeto SqlCommand llamado Comando que representa un comando SQL
            //que se ejecutará en la base de datos.
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Guardar_us", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@nOpcion", SqlDbType.Int).Value = nOpcion;
                Comando.Parameters.Add("@nCodigo_Usuario", SqlDbType.Int).Value = oUs.Codigo_Usuario;
                Comando.Parameters.Add("@cUsuario", SqlDbType.VarChar).Value = oUs.Usuario;
                Comando.Parameters.Add("@cContrasennia", SqlDbType.VarChar).Value = oUs.Contrasennia;
                Comando.Parameters.Add("@cNombreCompleto", SqlDbType.VarChar).Value = oUs.Nombre_Completo;
                Comando.Parameters.Add("@cCargo_Usuario", SqlDbType.VarChar).Value = oUs.Cargo_Usuario;
                Comando.Parameters.Add("@bAdmin", SqlDbType.Bit).Value = oUs.Admin;

                SqlCon.Open();

                Rpta = Comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo registrar los datos";
            }
            catch (Exception ex)
            {

                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }
        //Se ejecuta el comando (Comando.ExecuteNonQuery()) y se verifica si al menos una fila fue afectada en la base de datos. Si es así, se establece Rpta como "OK";
        //de lo contrario, se establece como "No se pudo registrar los datos".

        public string Eliminar_us(int Codigo_Usuario)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Eliminar_us", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@nCodigo_Usuario", SqlDbType.Int).Value = Codigo_Usuario;
                SqlCon.Open();

                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar los datos";
            }
            catch (Exception ex)
            {

                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }
        public DataTable Login_us(string cLogin, string cContrasennia)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SQLCon = new SqlConnection();

            try
            {
                SQLCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Login_us", SQLCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@cLogin_us", SqlDbType.VarChar).Value = cLogin;
                Comando.Parameters.Add("@cContrasennia", SqlDbType.VarChar).Value = cContrasennia;
                SQLCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (SQLCon.State == ConnectionState.Open) SQLCon.Close();
            }
        }




    }
}
