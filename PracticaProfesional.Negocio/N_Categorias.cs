﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using PracticaProfesional.Entidades;
using PracticaProfesional.Datos;


namespace PracticaProfesional.Negocio
{
    public class N_Categorias
    {
        public static DataTable Listado_ca(string cTexto)
        {
            D_Categorias Datos = new D_Categorias();
            return Datos.Listado_ca(cTexto);    
        }

        public static string Guadar_ca(int nOpcion, E_Categorias oCa)
        {
            D_Categorias Datos = new D_Categorias();
            return Datos.Guardar_ca(nOpcion, oCa);
        }
        public static string Eliminar_ca(int Codigo_Categoria)
        {
            D_Categorias Datos = new D_Categorias();
            return Datos.Eliminar_ca(Codigo_Categoria);
        }
    }
}
