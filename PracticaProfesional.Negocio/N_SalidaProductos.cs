using PracticaProfesional.Datos;
using PracticaProfesional.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaProfesional.Negocio
{
    public class N_SalidaProductos
    {
        public static DataTable Listado_Salida(string cTexto)
        {
            D_SalidaProductos Datos = new D_SalidaProductos();
            return Datos.Listado_Salida(cTexto);
        }

        public static DataTable Listado__detalle_Salida(int nCodigo_Salida)
        {
            D_SalidaProductos Datos = new D_SalidaProductos();
            return Datos.Listado__detalle_Salida(nCodigo_Salida);
        }

        public static string Guardar_Salida(E_SalidaProductos oSp, DataTable dTabla)
        {
            D_SalidaProductos Datos = new D_SalidaProductos();
            return Datos.Guardar_Salida(oSp, dTabla);
        }

        public static string Eliminar_sp(int Codigo_Salida)
        {
            D_SalidaProductos Datos = new D_SalidaProductos();
            return Datos.Eliminar_Salida(Codigo_Salida);
        }

        public static DataTable Listado_TipoVenta()
        {
            D_SalidaProductos Datos = new D_SalidaProductos();
            return Datos.Listado_TipoVenta();
        }

        public static DataTable Listado_cl_sp(string cTexto)
        {
            D_SalidaProductos Datos = new D_SalidaProductos();
            return Datos.Listado_cl_sp(cTexto);
        }

        public static DataTable Listado_pr_sp(string cTexto)
        {
            D_SalidaProductos Datos = new D_SalidaProductos();
            return Datos.Listado_pr_sp(cTexto);
        }
    }
}

