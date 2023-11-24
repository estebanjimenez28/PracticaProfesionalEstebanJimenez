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
    // la capa de negocio actúa como un intermediario entre la capa de presentación y la capa de datos,
    // facilitando el manejo de la lógica de negocio
    public class N_EntradaProductos
    {
        public static DataTable Listado_Entrada(string cTexto)
        {
            D_EntradaProductos Datos = new D_EntradaProductos();
            return Datos.Listado_Entrada(cTexto);
        }

        public static DataTable Listado_detalle_Entrada(int nCodigo_Entrada)
        {
            D_EntradaProductos Datos = new D_EntradaProductos();
            return Datos.Listado_detalle_Entrada(nCodigo_Entrada);
        }

        public static string Guadar_Entrada(E_EntradaProductos oTm, DataTable dTabla)
        {
            D_EntradaProductos Datos = new D_EntradaProductos();
            return Datos.Guardar_Entrada(oTm, dTabla);
        }
        public static string Eliminar_Entrada(int Codigo_Entrada)
        {
            D_EntradaProductos Datos = new D_EntradaProductos();
            return Datos.Eliminar_Entrada(Codigo_Entrada);
        }

 
        public static DataTable Listado_al_tm()
        {
            D_EntradaProductos Datos = new D_EntradaProductos();
            return Datos.Listado_al_tm();
        }

 
        public static DataTable Listado_pv_tm(string cTexto)
        {
            D_EntradaProductos Datos = new D_EntradaProductos();
            return Datos.Listado_pv_tm(cTexto);
        }

        public static DataTable Listado_us_tm(string cTexto)
        {
            D_EntradaProductos Datos = new D_EntradaProductos();
            return Datos.Listado_us_tm(cTexto);
        }

        public static DataTable Listado_pr_tm(string cTexto)
        {
            D_EntradaProductos Datos = new D_EntradaProductos();
            return Datos.Listado_pr_tm(cTexto);
        }

    }
}
