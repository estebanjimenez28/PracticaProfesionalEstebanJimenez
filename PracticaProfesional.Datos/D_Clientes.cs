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
    //En la clase datos se procede a llamar los diferentes procedimientos almacenados
    //que se encargaran de realizar las funciones dentro de los formularios, como por ejemplo,
    //listar, guardar y eliminar
    public class D_Clientes
    {
        public DataTable Listado_cl(string cTexto)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SQLCon = new SqlConnection();

            try
            {
                SQLCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Listado_cl", SQLCon);
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
        public string Guardar_cl(int nOpcion, E_Clientes oCl)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Guardar_cl", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@nOpcion", SqlDbType.Int).Value = nOpcion;
                Comando.Parameters.Add("@nCodigo_Cliente", SqlDbType.Int).Value = oCl.Codigo_Cliente;
                Comando.Parameters.Add("@nCodigo_Identificacion", SqlDbType.Int).Value = oCl.Codigo_TipoIdentificacion;
                Comando.Parameters.Add("@cNumeroDocumento", SqlDbType.VarChar).Value = oCl.NumeroDocumento;
                Comando.Parameters.Add("@cNombre", SqlDbType.VarChar).Value = oCl.Nombre;
                Comando.Parameters.Add("@cApellidos", SqlDbType.VarChar).Value = oCl.Apellidos;
                Comando.Parameters.Add("@cRazonSocialCliente", SqlDbType.VarChar).Value = oCl.RazonSocial_Cliente;
                Comando.Parameters.Add("@cCorreo", SqlDbType.VarChar).Value = oCl.Correo;
                Comando.Parameters.Add("@cTelefono", SqlDbType.VarChar).Value = oCl.Telefono;
                Comando.Parameters.Add("@cDireccion", SqlDbType.VarChar).Value = oCl.Direccion;
                Comando.Parameters.Add("@cObservacion", SqlDbType.VarChar).Value = oCl.Observacion;
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

        public string Eliminar_cl(int Codigo_Cliente)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Eliminar_cl", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@nCodigo_Cliente", SqlDbType.Int).Value = Codigo_Cliente;
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
        public DataTable Listado_TipoIdentificacion_cl(string cTexto)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SQLCon = new SqlConnection();

            try
            {
                SQLCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Listado_TipoIdentificacion_cl", SQLCon);
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



    }
}
