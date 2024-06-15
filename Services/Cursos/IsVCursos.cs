using Entities;
namespace Services.Cursos
{
    public interface IsVCursos
    {
        public Curso AddCurso(Curso curso);
        public List<Curso> GetAllCurso();
        public Curso GetCursoById(int Id);
        
    }
}
