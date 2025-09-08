using Ventas.Entities;

namespace Ventas.Client.Services
{
    public class VestaService
    {
        private List<VentaList> lista;
        private SucursalService sucursalService;
        private DirectorService directorService;
        public VestaService(SucursalService _sucursalService, DirectorService _directorService)
        {
            sucursalService = _sucursalService;
            directorService = _directorService;
            lista = new List<VentaList>();
            lista.Add(new VentaList { numeroEmpleado = 1, nombre = "Kevin Lopez", cargo = "supervisor", fechaContrato = DateTime.Now, cuotas = 12, ventas = 10, nombreSucursal = "La Paz", nombreDIrector = "Juan Carlos Bodoque" });
            lista.Add(new VentaList { numeroEmpleado = 2, nombre = "Luis Villarroel", cargo = "vendedor", fechaContrato = DateTime.Now, cuotas = 5, ventas = 6, nombreSucursal = "La Paz", nombreDIrector = "Juan Carlos Bodoque" });
        }
        public List<VentaList> listarVentas()
        {
            return lista;
        }
        public List<VentaList> eliminarVenta(int idVenta)
        {
            lista = lista.Where(p => p.numeroEmpleado != idVenta).ToList();
            return lista;
        }
        public Class1 ResuperarIdVenta(int idVenta)
        {
            var obj = lista.Where(p => p.numeroEmpleado == idVenta).FirstOrDefault();
            if (obj != null)
            {
                return new Class1 { numeroEmpleados = obj.numeroEmpleado, nombre = obj.nombre, cargo = obj.cargo, fechaContrato = obj.fechaContrato, cuota = obj.cuotas, venta = obj.ventas, idSucursal = sucursalService.obtenerIdSucursal(obj.nombreSucursal), idDirector = directorService.obtenerIdDirector(obj.nombreDIrector) };
            }
            else
            {
                return new Class1();
            }
        }
        public void guardarVenta(Class1 oVenta)
        {
            int idventa = lista.Select(p => p.numeroEmpleado).Max() + 1;
            lista.Add(new VentaList
            {
                numeroEmpleado = idventa,
                nombre = oVenta.nombre,
                cargo = oVenta.cargo,
                fechaContrato = oVenta.fechaContrato,
                cuotas = oVenta.cuota,
                ventas = oVenta.venta,
                nombreSucursal = sucursalService.obtenerNombreSucursal(oVenta.idSucursal),
                nombreDIrector = directorService.obtenerNombreDirector(oVenta.idDirector)
            });
        }
        public void editarVenta(Class1 oVenta)
        {
            var obj = lista.Where(p => p.numeroEmpleado == oVenta.numeroEmpleados).FirstOrDefault();
            if (obj != null)
            {
                obj.nombre = oVenta.nombre;
                obj.cargo = oVenta.cargo;
                obj.fechaContrato = oVenta.fechaContrato;
                obj.cuotas = oVenta.cuota;
                obj.ventas = oVenta.venta;
                obj.nombreSucursal = sucursalService.obtenerNombreSucursal(oVenta.idSucursal);
                obj.nombreDIrector = directorService.obtenerNombreDirector(oVenta.idDirector);

            }

        }
    }
}
