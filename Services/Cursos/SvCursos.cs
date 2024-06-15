﻿using Entities;
using Microsoft.EntityFrameworkCore;
using Services.MyDbContext;

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
            return _myDbContext.Cursos.ToList();
        }

        public Curso GetCursoById(int id)
        {
            return _myDbContext.Cursos.SingleOrDefault(x => x.Id == id);
        }
        #endregion
    }
}
