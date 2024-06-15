using Microsoft.AspNetCore.Mvc;

namespace API_Matriculas.Controllers
{
    public class CarrerasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
