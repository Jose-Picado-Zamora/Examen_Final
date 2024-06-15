using Microsoft.AspNetCore.Mvc;
using Services;
using Services.Niveles;
using Services.Matriculas;
using Services.Estudiantes;
using Services.Cursos;
using Services.Carreras;
using Entities;

namespace API_Matriculas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatriculaController : Controller
    {
        private IsVNiveles _svNiveles;
        private IsVMatriculas _svMatriculas;
        private IsVEstudiantes _svEstudiantes;
        private IsVCursos _svCurso;
        private ISvCarrera _svCarrera;
        public MatriculaController(IsVCursos svCursos
            , IsVMatriculas svMatriculas, ISvCarrera svCarreras,
            IsVEstudiantes svEstudiantes, IsVNiveles svNiveles
            )
        {
            _svNiveles = svNiveles;
            _svMatriculas = svMatriculas;
            _svEstudiantes = svEstudiantes;
            _svCurso = svCursos;
            _svCarrera = svCarreras;
        }

        [HttpGet("{id}")]
        public Curso Get(int id)
        {
            return _svCurso.GetCursoById(id);
        }

        [HttpPost]
        public void Post([FromBody] Curso curso)
        {
            _svCurso.AddCurso(curso);
        }

        [HttpPost("{Niveles}")]
        public void Post([FromBody] Nivel nivel)
        {
            _svNiveles.AddNiveles(nivel);
        }

        [HttpPost("{Carrera}")]
        public void Post([FromBody] Carrera carrera)
        {
            _svCarrera.AddCarrera(carrera);
        }

        [HttpPost("{Estudiante}")]
        public void Post([FromBody] Estudiante estudiante)
        {
            _svEstudiantes.AddEstudiante(estudiante);
        }

        [HttpPost("{Matricula}")]
        public void Post([FromBody] Matricula matricula)
        {
            _svMatriculas.AddMatricula(matricula);
        }









    }
}
