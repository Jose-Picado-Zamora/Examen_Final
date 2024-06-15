using Entities;
using Microsoft.EntityFrameworkCore;
using Services.MyDbContext;

namespace Services.Niveles
{
    public class SvNiveles : IsVNiveles
    {
        private MyContext _myDbContext = default!;
        public SvNiveles()
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

        public Nivel GetNivelById(int Id)
        {
            return _myDbContext.Niveles.SingleOrDefault(x => x.Id == Id);
        }
    }
}
