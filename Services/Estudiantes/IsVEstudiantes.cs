using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Services.Estudiantes
{
    public interface IsVEstudiantes
    {
        public Estudiante AddEstudiante(Estudiante estudiante);
        public Estudiante GetEstudianteById(int Id);
        public List<Estudiante> GetAllEstudiantes();
    }
}
