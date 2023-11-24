using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaProfesional.Entidades
{
    public class E_Productos
    {
        //Se definen las propiedades simples
        public int Codigo_Producto { get; set; }
        public string Descripcion_Producto{ get; set; }
        public int Codigo_Marca { get; set; }
        public int Codigo_Unidad{ get; set; }
        public int Codigo_Categoria { get; set; }
        public decimal Stock_min { get; set; }
        public decimal Stock_max{ get; set; }
        public decimal Precio_Venta { get; set; }   




    }
}
