using Ventas.Entities;

namespace Ventas.Client.Services
{
    public class SucursalService
    {
        private List<Sucursal> sucursals;
        public SucursalService()
        {
            sucursals = new List<Sucursal>();
            sucursals.Add(new Sucursal() { idSucursal = 1, nombreSucursal = "La Paz" });
            sucursals.Add(new Sucursal() { idSucursal = 2, nombreSucursal = "Santa Cruz" });
            sucursals.Add(new Sucursal() { idSucursal = 3, nombreSucursal = "Cochabamba" });
            sucursals.Add(new Sucursal() { idSucursal = 4, nombreSucursal = "Sucre" });
        }
        public List<Sucursal> listarSucursales()
        {
            return sucursals;
        }
        public int obtenerIdSucursal(string nombreSU)
        {
            var obj = sucursals.Where(p => p.nombreSucursal == nombreSU).FirstOrDefault();
            if (obj != null)
                return obj.idSucursal;
            else
                return 0;

        }
        public string obtenerNombreSucursal(int idSucursal)
        {
            var obj = sucursals.Where(p => p.idSucursal == idSucursal).FirstOrDefault();
            if (obj == null) return "";
            else
                return obj.nombreSucursal;
        }
    }
}
