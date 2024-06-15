using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Services.Carreras
{
    public interface ISvCarrera
    {
        public Carrera AddCarrera(Carrera Carrera);
        public List<Carrera> GetAllCarrera();
        public Carrera GetCarreraById(int Id);

    }
}
