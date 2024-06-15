using Microsoft.AspNetCore.Mvc;

namespace API_Matriculas.Controllers
{
    public class EstudiantesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
