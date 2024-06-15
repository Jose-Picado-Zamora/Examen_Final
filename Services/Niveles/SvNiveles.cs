using Entities;
using Microsoft.EntityFrameworkCore;
using Services.MyDbContext;

namespace Services.Niveles
{
    public class SvNiveles : IsVNiveles
    {
        private MyContext _myDbContext = default!;
        public SvCursos()
        {
            _myDbContext = new MyContext();
        }
        public Nivel AddNiveles(Nivel nivel)
        {
            _myDbContext.Niveles.Add(nivel);
            _myDbContext.SaveChanges();

            return nivel;
        }

        public List<Nivel> GetAllnivel()
        {
            return _myDbContext.Niveles.ToList();
        }

        public Nivel GetNivelById(int id)
        {
            return _myDbContext.Niveles.SingleOrDefault(x => x.Id == id);
        }
    }
}
