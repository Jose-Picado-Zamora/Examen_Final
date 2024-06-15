using Microsoft.AspNetCore.Mvc;

namespace API_Matriculas.Controllers
{
    public class CursosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
