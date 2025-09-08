using System.IO;
using Ventas.Entities;

namespace Ventas.Client.Services
{
    public class DirectorService
    {
        private List<Director> directors;
        public DirectorService()
        {
            directors = new List<Director>();
            directors.Add(new Director() { idDirector = 1, nombreDirector = "Juan Carlos Bodoque" });
            directors.Add(new Director() { idDirector = 2, nombreDirector = "Tulio Sagalino" });
            directors.Add(new Director() { idDirector = 3, nombreDirector = "Roberto Gonzales" });
        }
        public List<Director> listarDirecores()
        {
            return directors;
        }
        public int obtenerIdDirector(string nomDirec)
        {
            var obj = directors.Where(p => p.nombreDirector == nomDirec).FirstOrDefault();
            if (obj == null)
                return 0;
            else return obj.idDirector;
        }
        public string obtenerNombreDirector(int idDi)
        {
            var obj = directors.Where(p => p.idDirector == idDi).FirstOrDefault();
            if (obj == null)
                return "";
            else return obj.nombreDirector;
        }
    }
}
