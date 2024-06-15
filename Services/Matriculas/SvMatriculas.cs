using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Services.Matriculas
{
    public class SvMatricula : IsVMatriculas
    {
        private MyContext _myDbContext = default!;
        public SvMatricula()
        {
            _myDbContext = new MyContext();
        }
        #region READS 
        public List<Matricula> GetAllMatriculas()
        {
            return _myDbContext.Matriculas.ToList();
        }

        public Matricula GetMatriculaById(int id)
        {
            return _myDbContext.Matriculas.SingleOrDefault(x => x.id == id);
        }
        #endregion

        #region WRITES
        public Matricula AddMatricula(Matricula Matricula)
        {
            _myDbContext.Matriculas.Add(Matricula);
            _myDbContext.SaveChanges();

            return Matricula;
        }
        #endregion
    }
}
