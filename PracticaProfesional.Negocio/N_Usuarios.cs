﻿using PracticaProfesional.Datos;
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
    public class N_Usuarios
    {
        public static DataTable Listado_us(string cTexto)
        {
            D_Usuarios Datos = new D_Usuarios();
            return Datos.Listado_us(cTexto);
        }

        public static string Guadar_us(int nOpcion, E_Usuarios oUs)
        {
            D_Usuarios Datos = new D_Usuarios();
            return Datos.Guardar_us(nOpcion, oUs);
        }
        public static string Eliminar_us(int Codigo_Usuario)
        {
            D_Usuarios Datos = new D_Usuarios();
            return Datos.Eliminar_us(Codigo_Usuario);
        }

        public static DataTable Login_us(string cLogin, string cContrasennia)
        {
            D_Usuarios Datos = new D_Usuarios();
            return Datos.Login_us(cLogin, cContrasennia);
        }


    }
}

