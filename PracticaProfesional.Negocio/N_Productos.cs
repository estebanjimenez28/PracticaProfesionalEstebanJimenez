using PracticaProfesional.Datos;
using PracticaProfesional.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaProfesional.Negocio
{
    // la capa de negocio actúa como un intermediario entre la capa de presentación y la capa de datos,
    // facilitando el manejo de la lógica de negocio
    public class N_Productos
    {
        public static DataTable Listado_pr(string cTexto)
        {
            D_Productos Datos = new D_Productos();
            return Datos.Listado_pr(cTexto);
        }

   

        public static string Guadar_pr(int nOpcion, E_Productos oPr)
        {
            D_Productos Datos = new D_Productos();
            return Datos.Guardar_pr(nOpcion, oPr);
        }
        public static string Eliminar_pr(int Codigo_Producto)
        {
            D_Productos Datos = new D_Productos();
            return Datos.Eliminar_pr(Codigo_Producto);
        }

        public static DataTable Listado_ma_pr(string cTexto)
        {
            D_Productos Datos = new D_Productos();
            return Datos.Listado_ma_pr(cTexto);
        }

        public static DataTable Listado_um_pr(string cTexto)
        {
            D_Productos Datos = new D_Productos();
            return Datos.Listado_um_pr(cTexto);
        }
        public static DataTable Listado_ca_pr(string cTexto)
        {
            D_Productos Datos = new D_Productos();
            return Datos.Listado_ca_pr(cTexto);
        }
        public static DataTable Ver_Stock_Actual_Producto(int nCodigo_Producto)
        {
            D_Productos Datos = new D_Productos();
            return Datos.Ver_Stock_Actual_Producto(nCodigo_Producto);
        }
    }
}
