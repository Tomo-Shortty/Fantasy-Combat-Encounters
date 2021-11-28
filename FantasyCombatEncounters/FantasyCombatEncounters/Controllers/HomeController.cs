using Microsoft.AspNetCore.Mvc;

namespace FantasyCombatEncounters.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
