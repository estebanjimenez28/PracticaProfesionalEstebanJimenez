using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaProfesional.Entidades
{
    public class E_EntradaProductos
    {
        //Se definen las propiedades simples
        public int Codigo_Entrada { get; set; } 
        public string NumeroDocumento { get; set; } 
        public int Codigo_Proveedor { get; set; }
        public int Codigo_Usuario { get; set; }
        public int Codigo_Almacen { get; set; }
        public DateTime Fecha { get; set; }  
        public string Observacion { get; set; } 
        public decimal Subtotal { get; set; }   
        public decimal Iva { get; set; }    
        public decimal Total { get; set; }  
       
    }
}
