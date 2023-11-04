using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaProfesional.Entidades
{
    public class E_Usuarios
    {
        public int Codigo_Usuario { get; set; }
        public string Usuario { get; set; }
        public string Nombre_Completo { get; set; }
        public string Contrasennia { get; set; }
        public string Cargo_Usuario { get; set; }
        public bool Admin {  get; set; }    


    }
}
