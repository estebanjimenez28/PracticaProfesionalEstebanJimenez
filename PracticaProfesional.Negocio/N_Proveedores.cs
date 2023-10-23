using PracticaProfesional.Datos;
using PracticaProfesional.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace PracticaProfesional.Negocio
{
    public class N_Proveedores
    {
        public static DataTable Listado_pv(string cTexto)
        {
            D_Proveedores Datos = new D_Proveedores();
            return Datos.Listado_pv(cTexto);
        }

        public static string Guadar_pv(int nOpcion, E_Proveedores oPv)
        {
            D_Proveedores Datos = new D_Proveedores();
            return Datos.Guardar_pv(nOpcion, oPv);
        }
        public static string Eliminar_pv(int Codigo_Proveedor)
        {
            D_Proveedores Datos = new D_Proveedores();
            return Datos.Eliminar_pv(Codigo_Proveedor);
        }

        public static DataTable Listado_pr_pv(string cTexto)
        {
            D_Proveedores Datos = new D_Proveedores();
            return Datos.Listado_pr_pv(cTexto);
        }


    }
}

