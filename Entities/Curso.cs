using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Curso
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Estudiante>? ListaEstudiantes { get; set; }
        public int NivelId { get; set; }
        public Nivel? Nivel { get; set; }
        public int CarreraId { get; set; }
        public Carrera? Carrera { get; set; }
    }
}
