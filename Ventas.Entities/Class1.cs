using System.ComponentModel.DataAnnotations;

namespace Ventas.Entities
{
    public class Class1
    {
        [Required (ErrorMessage = "Ingrese numero de empleados")]
        [Range(1, int.MaxValue, ErrorMessage = "Numero de empleados debe ser un entero positivo.")]
        public int numeroEmpleados { get; set; }
        [Required(ErrorMessage ="Ingrese nombre")]
        public string nombre { get; set; }
        [Required(ErrorMessage ="Ingrese Edad")]
        [Range(18, 120, ErrorMessage = "La edad minima permitida es 18.")]
        public int edad { get; set; }
        [Required(ErrorMessage ="Ingrese cargo")]
        public string cargo { get; set; }
        [Required(ErrorMessage ="Ingrese Fecha")]
        [DataType(DataType.Date)]
        public DateTime? fechaContrato { get; set; }
        [Required(ErrorMessage ="Ingrese cuota")]
        [Range(0, double.MaxValue, ErrorMessage = "Cuota debe ser un número no negativo.")]
        public double? cuota { get; set; }
        [Required(ErrorMessage ="Ingrese venta")]
        [Range(0, int.MaxValue, ErrorMessage = "Venta debe ser un número no negativo.")]
        public int? venta { get; set; }
    }
}
