using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticaProfesional.Entidades;

namespace PracticaProfesional.Datos
{
    public class D_SalidaProductos
    {
      
            public DataTable Listado_Salida(string cTexto)
            {
                SqlDataReader Resultado;
                DataTable Tabla = new DataTable();
                SqlConnection SQLCon = new SqlConnection();

                try
                {
                    SQLCon = Conexion.getInstancia().CrearConexion();
                    SqlCommand Comando = new SqlCommand("USP_Listado_Salida", SQLCon);
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

        public DataTable Listado__detalle_Salida(int nCodigo_Salida)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SQLCon = new SqlConnection();

            try
            {
                SQLCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Listado_Detalle_Salida", SQLCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@nCodigo_Salida", SqlDbType.VarChar).Value = nCodigo_Salida;
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

        public string Guardar_Salida(E_SalidaProductos oSp, DataTable dTabla)
            {
                string Rpta = "";
                SqlConnection SqlCon = new SqlConnection();
                try
                {
                    SqlCon = Conexion.getInstancia().CrearConexion();
                    SqlCommand Comando = new SqlCommand("USP_Guardar_Salida", SqlCon);
                    Comando.CommandType = CommandType.StoredProcedure;
                    Comando.Parameters.Add("@nCodigo_TipoVenta", SqlDbType.Int).Value = oSp.Codigo_TipoVenta;
                    Comando.Parameters.Add("@cNumeroDocumento", SqlDbType.VarChar).Value = oSp.NumeroDocumento;
                    Comando.Parameters.Add("@nCodigo_Cliente", SqlDbType.Int).Value = oSp.Codigo_Ciente;
                    Comando.Parameters.Add("@cNrodocumento_Cliente", SqlDbType.VarChar).Value = oSp.nDocumentoCliente;
                    Comando.Parameters.Add("@cRazon_social_Cliente", SqlDbType.VarChar).Value = oSp.RazonSocial_Cliente;
                    Comando.Parameters.Add("@fFecha_Salida", SqlDbType.Date).Value = oSp.Fecha_Salida;
                    Comando.Parameters.Add("@cObservacion_Salida", SqlDbType.Text).Value = oSp.Observacion;
                    Comando.Parameters.Add("@nSubtotal", SqlDbType.Decimal).Value = oSp.Subtotal;
                    Comando.Parameters.Add("@nIva", SqlDbType.Decimal).Value = oSp.Iva;
                    Comando.Parameters.Add("@nTotal", SqlDbType.Decimal).Value = oSp.Total;
                    Comando.Parameters.Add("@tDetalle", SqlDbType.Structured).Value = dTabla;

                    SqlParameter ParCodigo = new SqlParameter();
                    ParCodigo.ParameterName = "@nCodigo_Salida";
                    ParCodigo.SqlDbType = SqlDbType.Int;
                    ParCodigo.Direction = ParameterDirection.Output;
                    Comando.Parameters.Add(ParCodigo);
                    SqlCon.Open();
                    Comando.ExecuteNonQuery();
                    Rpta = Convert.ToString(ParCodigo.Value);
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

            public string Eliminar_Salida(int Codigo_Salida)
            {
                string Rpta = "";
                SqlConnection SqlCon = new SqlConnection();
                try
                {
                    SqlCon = Conexion.getInstancia().CrearConexion();
                    SqlCommand Comando = new SqlCommand("USP_Eliminar_Salida", SqlCon);
                    Comando.CommandType = CommandType.StoredProcedure;
                    Comando.Parameters.Add("@nCodigo_Salida", SqlDbType.Int).Value = Codigo_Salida;
                    SqlCon.Open();
                    Rpta = Comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo eliminar los datos";
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

            public DataTable Listado_TipoVenta()
            {
                SqlDataReader Resultado;
                DataTable Tabla = new DataTable();
                SqlConnection SQLCon = new SqlConnection();

                try
                {
                    SQLCon = Conexion.getInstancia().CrearConexion();
                    SqlCommand Comando = new SqlCommand("USP_Listado_TipoVenta", SQLCon);
                    Comando.CommandType = CommandType.StoredProcedure;
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

            public DataTable Listado_cl_sp(string cTexto)
            {
                SqlDataReader Resultado;
                DataTable Tabla = new DataTable();
                SqlConnection SQLCon = new SqlConnection();

                try
                {
                    SQLCon = Conexion.getInstancia().CrearConexion();
                    SqlCommand Comando = new SqlCommand("USP_Listado_cliente_sp", SQLCon);
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

            public DataTable Listado_pr_sp(string cTexto)
            {
                SqlDataReader Resultado;
                DataTable Tabla = new DataTable();
                SqlConnection SQLCon = new SqlConnection();

                try
                {
                    SQLCon = Conexion.getInstancia().CrearConexion();
                    SqlCommand Comando = new SqlCommand("USP_Listado_pr_sp", SQLCon);
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




