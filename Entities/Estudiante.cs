namespace Entities
{
    public class Estudiante
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public int CursoId { get; set; }
        public Curso? Curso { get; set; }

        public int CarreraId { get; set; }
        public Carrera? Carrera { get; set; }

    }
    
}
