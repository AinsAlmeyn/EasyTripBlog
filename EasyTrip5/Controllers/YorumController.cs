using Microsoft.AspNetCore.Mvc;

namespace EasyTrip5.Controllers
{
    public class YorumController : Controller
    {
        public IActionResult Yorumlar()
        {
            return View();
        }
    }
}
