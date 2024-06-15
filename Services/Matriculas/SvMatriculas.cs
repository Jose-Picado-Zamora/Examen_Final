using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.MyDbContext;
using Entities;

namespace Services.Matriculas
{
    public class SvMatriculas : IsVMatriculas
    {
        private MyContext _myDbContext = default!;
        public SvMatriculas()
        {
            _myDbContext = new MyContext();
        }
        #region READS 
        public List<Matricula> GetAllMatriculas()
        {
            return _myDbContext.Matriculas.ToList();
        }

        public Matricula GetMatriculaById(int Id)
        {
            return _myDbContext.Matriculas.SingleOrDefault(x => x.Id == Id);
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
