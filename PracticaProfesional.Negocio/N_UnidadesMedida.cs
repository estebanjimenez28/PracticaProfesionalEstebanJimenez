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
    public class N_UnidadesMedida
    {
        public static DataTable Listado_um(string cTexto)
        {
            D_UnidadesMedida Datos = new D_UnidadesMedida();
            return Datos.Listado_um(cTexto);
        }

        public static string Guadar_um(int nOpcion, E_UnidadesMedida oUm)
        {
            D_UnidadesMedida Datos = new D_UnidadesMedida();
            return Datos.Guardar_um(nOpcion, oUm);
        }
        public static string Eliminar_um(int Codigo_Unidad)
        {
            D_UnidadesMedida Datos = new D_UnidadesMedida();
            return Datos.Eliminar_um(Codigo_Unidad);
        }
    }
}
