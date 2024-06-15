using Microsoft.AspNetCore.Mvc;

namespace API_Matriculas.Controllers
{
    public class NivelesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
