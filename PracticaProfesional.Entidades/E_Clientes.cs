using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaProfesional.Entidades
{
    public class E_Clientes
    {
        public int Codigo_Cliente { get; set; }
        public int Codigo_TipoIdentificacion { get; set; }
        public string NumeroDocumento { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string RazonSocial_Cliente { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Observacion { get; set; }
    }
}
