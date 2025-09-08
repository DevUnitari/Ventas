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
        public string cargo { get; set; }
        public DateTime? fechaContrato { get; set; }
        public double? cuotas { get; set; }
        public int? ventas { get; set; }
        public string nombreSucursal { get; set; } = string.Empty;
        public string nombreDIrector { get; set; } = string.Empty;
    }
}
