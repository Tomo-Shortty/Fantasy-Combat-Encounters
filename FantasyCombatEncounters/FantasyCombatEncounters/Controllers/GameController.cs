using Microsoft.AspNetCore.Mvc;

namespace FantasyCombatEncounters.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
