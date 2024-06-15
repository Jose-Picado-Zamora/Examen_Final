using Microsoft.AspNetCore.Mvc;

namespace API_Matriculas.Controllers
{
    public class MatriculasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
