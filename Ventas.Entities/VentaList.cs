using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Entities
{
    public class VentaList
    {
        public int numeroEmpleado { get; set; }
        public string nombre { get; set; }
        public int edad { get; set; }
        public string cargo { get; set; }
        public DateTime? fechaContrato { get; set; }
        public double? cuota { get; set; }
        public int? venta { get; set; }
    }
}
