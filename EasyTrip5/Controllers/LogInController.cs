using Microsoft.AspNetCore.Mvc;

namespace EasyTrip5.Controllers
{
    public class LogInController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
