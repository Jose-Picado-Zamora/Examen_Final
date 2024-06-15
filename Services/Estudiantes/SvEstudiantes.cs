using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Services.Estudiantes
{
    public class SvEstudiante : IsVEstudiantes
    {
        private MyContext _myDbContext = default!;
        public SvEstudiante()
        {
            _myDbContext = new MyContext();
        }
        #region Reads
        public List<Estudiante> GetAllEstudiantes()
        {
            return _myDbContext.Estudiantes.ToList();

        }
        public Estudiante GetEstudianteById(int id)
        {
            return _myDbContext.Estudiantes.SingleOrDefault(x => x.id == id);
        }
        #endregion

        #region Writes
        public Estudiante AddEstudiante(Estudiante Estudiante)
        {

            _myDbContext.Estudiantes.Add(Estudiante);
            _myDbContext.SaveChanges();

            return Estudiante;
        }
        #endregion
    }
}
