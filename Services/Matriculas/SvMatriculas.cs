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
            return _myDbContext.Matriculas.Include(x => x.Curso).ThenInclude(x => x.Nivel).Include(x => x.Estudiante).ToList();
        }

        public Matricula GetMatriculaById(int Id)
        {
            return _myDbContext.Matriculas.SingleOrDefault(x => x.Id == Id);
        }

        public List<Estudiante> GetEstudiantesByNivel(int NivelId, int CarreraId)
        {
            List<Estudiante> estudiantes = new List<Estudiante>();
            List<Matricula> AllMatriculas= GetAllMatriculas();
            foreach (var mat in AllMatriculas)
            {
                if (mat.Curso.NivelId == NivelId && mat.Curso.CarreraId == CarreraId)
                {
                    estudiantes.Add(mat.Estudiante);
                }
            }
           
            return estudiantes;

        }
        public List<Estudiante> GetEstudiantesByNivelAndCarrera(int nivelId, int carreraId)
        {
            return _myDbContext.Matriculas
                .Include(m => m.Estudiante)
                .Include(m => m.Curso)
                .Where(m => m.Curso.NivelId == nivelId && m.Curso.CarreraId == carreraId)
                .Select(m => m.Estudiante)
                .ToList();
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
