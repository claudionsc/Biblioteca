using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Controllers
{
    public class LivroControler : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
