using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Carrera
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<Estudiante>? ListaEstudiantes { get; set; }
        public List<Curso>? ListaCursos { get; set; }
    }
}
