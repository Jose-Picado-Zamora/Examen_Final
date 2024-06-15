using Entities;
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
        public Curso AddCurso(Curso curso)
        {
            _myDbContext.Cursos.Add(curso);
            _myDbContext.SaveChanges();

            return curso;
        }

        public List<Curso> GetAllCurso()
        {
            return _myDbContext.Cursos.ToList();
        }

        public Curso GetCursoById(int Id)
        {
            return _myDbContext.Cursos.SingleOrDefault(x => x.Id == Id);
        }
    }
}
