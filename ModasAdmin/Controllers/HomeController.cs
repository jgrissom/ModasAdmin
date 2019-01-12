using Microsoft.AspNetCore.Mvc;

namespace ModasAdmin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
