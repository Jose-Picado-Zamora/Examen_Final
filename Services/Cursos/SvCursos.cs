using Entities;
using Microsoft.EntityFrameworkCore;
using Services.MyDbContext;
using System.Collections.Generic;

namespace Services.Cursos
{
    public class SvCursos : IsVCursos
    {
        private MyContext _myDbContext = default!;
        public SvCursos()
        {
            _myDbContext = new MyContext();
        }

        #region WRITES
        public Curso AddCurso(Curso curso)
        {
            _myDbContext.Cursos.Add(curso);
            _myDbContext.SaveChanges();

            return curso;
        }
        #endregion

        #region READS
        public List<Curso> GetAllCurso()
        {
            return _myDbContext.Cursos.Include(x => x.ListaEstudiantes).Include(x => x.Nivel).Include(x => x.Carrera).ToList();
        }

        public Curso GetCursoById(int Id)
        {
            return _myDbContext.Cursos.Include(x=>x.ListaEstudiantes).SingleOrDefault(x => x.Id == Id);
        }
        #endregion

    }
}
