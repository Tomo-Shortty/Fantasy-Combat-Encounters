using Microsoft.AspNetCore.Mvc;

namespace FantasyCombatEncounters.Controllers
{
    public class SetupController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
