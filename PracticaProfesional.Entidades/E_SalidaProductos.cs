using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaProfesional.Entidades
{
    public class E_SalidaProductos
    {
        public int Codigo_Salida { get; set; }
        public int Codigo_TipoVenta { get; set; }
        public string NumeroDocumento { get; set; }
        public int Codigo_Ciente { get; set; }
        public string nDocumentoCliente { get; set; }
        public string RazonSocial_Cliente { get; set; }
        public DateTime Fecha_Salida { get; set; }
        public string Observacion { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Iva { get; set; }
        public decimal Total { get; set; }
    }

}
