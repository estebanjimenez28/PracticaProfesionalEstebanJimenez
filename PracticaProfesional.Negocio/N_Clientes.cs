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
    public class N_Clientes
    {
        public static DataTable Listado_cl(string cTexto)
        {
            D_Clientes Datos = new D_Clientes();
            return Datos.Listado_cl(cTexto);
        }

        public static string Guadar_cl(int nOpcion, E_Clientes oCl)
        {
            D_Clientes Datos = new D_Clientes();
            return Datos.Guardar_cl(nOpcion, oCl);
        }
        public static string Eliminar_cl(int Codigo_Cliente)
        {
            D_Clientes Datos = new D_Clientes();
            return Datos.Eliminar_cl(Codigo_Cliente);
        }
        public static DataTable Listado_TipoIdentificacion_cl(string cTexto)
        {
            D_Clientes Datos = new D_Clientes();
            return Datos.Listado_TipoIdentificacion_cl(cTexto);
        }



    }
}