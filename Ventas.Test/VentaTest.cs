using System.ComponentModel.DataAnnotations;
using Ventas.Entities;
using Xunit;
namespace Ventas.Test
{
    public class VentaTest
    {private List<ValidationResult> ValidarModelo (object modelo)
        {
            var resultados=new List<ValidationResult>();    
            var contexto= new ValidationContext(modelo,null,null);
            Validator.TryValidateObject(modelo, contexto,resultados,true);
            return resultados;

        }
        [Fact]
        public void ValidarUnitario()
        {
            var venta = new Class1();
            var errores =ValidarModelo(venta);
            Assert.Contains(errores, e => e.ErrorMessage!.Contains("Ingrese numero de empleados") || e.ErrorMessage!.Contains("Numero de empleados debe ser un entero positivo."));
            Assert.Contains(errores, e => e.ErrorMessage!.Contains("Ingrese nombre"));
            Assert.Contains(errores, e => e.ErrorMessage!.Contains("Ingrese Edad") || e.ErrorMessage!.Contains("La edad minima permitida es 18."));
            Assert.Contains(errores, e => e.ErrorMessage!.Contains("Ingrese cargo"));
            Assert.Contains(errores, e => e.ErrorMessage!.Contains("Ingrese Fecha"));
            Assert.Contains(errores, e => e.ErrorMessage!.Contains("Ingrese cuota") || e.ErrorMessage!.Contains("Cuota debe ser un número no negativo."));
            Assert.Contains(errores, e => e.ErrorMessage!.Contains("Ingrese venta") || e.ErrorMessage!.Contains("Venta debe ser un número no negativo."));
        }
        [Fact]
        public void validarUnitario2()
        {
            var venta = new Class1
            {
                numeroEmpleados = 1,
                nombre="Carlos",
                edad=19,
                cargo="Supervisor",
                fechaContrato= DateTime.Today,
                cuota=29,
                venta=20
            };
            var errores = ValidarModelo(venta);
            Assert.Empty(errores);
        }
    }
}