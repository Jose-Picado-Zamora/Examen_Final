using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.MyDbContext;
using Entities;

namespace Services.Estudiantes
{
    public class SvEstudiantes : IsVEstudiantes
    {
        private MyContext _myDbContext = default!;
        public SvEstudiantes()
        {
            _myDbContext = new MyContext();
        }
        #region Reads
        public List<Estudiante> GetAllEstudiantes()
        {
            return _myDbContext.Estudiantes.ToList();

        }
        public Estudiante GetEstudianteById(int Id)
        {
            return _myDbContext.Estudiantes.SingleOrDefault(x => x.Id == Id);
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
