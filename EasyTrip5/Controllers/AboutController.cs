using Microsoft.AspNetCore.Mvc;
using EasyTrip5.Models.Entities;
using System.Linq;

namespace EasyTrip5.Controllers
{
    public class AboutController : Controller
    {
        EasyTripBackEndContext context = new EasyTripBackEndContext();
        public IActionResult Index()
        {
            var degerler = context.Hakkımızdas.ToList();
            return View(degerler);
        }
    }
}
