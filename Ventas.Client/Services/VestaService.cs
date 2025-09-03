using Ventas.Entities;

namespace Ventas.Client.Services
{
    public class VestaService
    {
        private List<VentaList> lista;
        public VestaService()
        {
            lista = new List<VentaList>();
            lista.Add(new VentaList { numeroEmpleado = 1, nombre = "Kevin Lopez", cargo = "supervisor", fechaContrato = DateTime.Now, cuota = 12, venta = 10 });
            lista.Add(new VentaList { numeroEmpleado = 2, nombre = "Luis Villarroel", cargo = "vendedor", fechaContrato = DateTime.Now, cuota = 5, venta = 6 });
        }
        public List<VentaList> listarVentas()
        {
            return lista;
        }
        public List<VentaList> eliminarVenta(int idVenta)
        {
            var listaQueda = lista.Where(p => p.numeroEmpleado == idVenta).ToList();
            lista = listaQueda;
            return lista;
        }
        public Class1 ResuperarIdVenta(int idVenta)
        {
            var obj = lista.Where(p => p.numeroEmpleado == idVenta).FirstOrDefault();
            if (obj != null)
            {
                return new Class1 { numeroEmpleados = obj.numeroEmpleado, nombre = obj.nombre, cargo = obj.cargo, fechaContrato = obj.fechaContrato, cuota = obj.cuota, venta = obj.venta };
            }
            else
            {
                return new Class1();
            }
        }
        public void guardarVenta(Class1 oVenta)
        {
            lista.Add(new VentaList { numeroEmpleado = oVenta.numeroEmpleados, nombre = oVenta.nombre, cargo = oVenta.cargo, fechaContrato = oVenta.fechaContrato, cuota = oVenta.cuota, venta = oVenta.venta });
        }
        public void editarVenta(Class1 oVenta)
        {
            var obj = lista.Where(p => p.numeroEmpleado == oVenta.numeroEmpleados).FirstOrDefault();
            if (obj != null)
            {
                obj.nombre = oVenta.nombre;
                obj.cargo = oVenta.cargo;
                obj.fechaContrato = oVenta.fechaContrato;
                obj.cuota = oVenta.cuota;
                obj.venta = oVenta.venta;

            }

        }
    }
}
