using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.MyDbContext;

using Entities;
namespace Services.Carreras
{
    public class SvCarrera : ISvCarrera
    {
        private MyContext _myDbContext = default!;
        public SvCarrera()
        {
            _myDbContext = new MyContext();
        }

        #region reads
        public List<Carrera> GetAllCarrera()
        {
            return _myDbContext.Carreras.ToList();
        }

        public Carrera GetCarreraById(int Id)
        {
            return _myDbContext.Carreras.SingleOrDefault(x => x.Id == Id);
        }
        #endregion

        #region writes
        public Carrera AddCarrera(Carrera Carrera)
        {
            _myDbContext.Carreras.Add(Carrera);
            _myDbContext.SaveChanges();
            return Carrera;
        }
        #endregion
    }
}
