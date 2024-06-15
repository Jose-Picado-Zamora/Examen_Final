using Entities;

namespace Services.Niveles
{
    public interface IsVNiveles
    {
        public Nivel AddNiveles(Nivel nivel);
        public List<Nivel> GetAllnivel();
        public Nivel GetNivelById(int Id);

    }
}