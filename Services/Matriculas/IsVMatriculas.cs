using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Services.Matriculas
{
    public interface IsVMatriculas
    {
        public Matricula AddMatricula(Matricula matricula);
        public Matricula GetMatriculaById(int id);
        public List<Matricula> GetAllMatriculas();
    }
}
