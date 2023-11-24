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
    public class N_Almacen
    {
        public static DataTable Listado_al(string cTexto)
        {
            D_Almacen Datos = new D_Almacen();
            return Datos.Listado_al(cTexto);
        }

        public static string Guadar_al(int nOpcion, E_Almacen oAl)
        {
            D_Almacen Datos = new D_Almacen();
            return Datos.Guardar_al(nOpcion, oAl);
        }
        public static string Eliminar_al(int Codigo_Almacen)
        {
            D_Almacen Datos = new D_Almacen();
            return Datos.Eliminar_al(Codigo_Almacen);
        }
    }
}
