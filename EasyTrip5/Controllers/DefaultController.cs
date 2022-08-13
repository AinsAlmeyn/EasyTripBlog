using EasyTrip5.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EasyTrip5.Controllers
{
    public class DefaultController : Controller
    {
        EasyTripBackEndContext context = new EasyTripBackEndContext();
        public IActionResult Index()
        {
            #region Resimli Açıklamalar

            var degerler = context.Blogs.OrderByDescending(x => x.Tarih).Take(2).ToList();
            ViewBag.Degerler = degerler;
            
            #endregion

            #region Popüler İlk On
            
            var degerler2 = context.Blogs.Take(10).ToList();
            ViewBag.Degerler2 = degerler2;

            #endregion

            #region Our Best Places Left
            var deger = context.Blogs.Take(3).OrderBy(x => x.Id).ToList();
            ViewBag.Obp = deger;
            #endregion

            #region Our Best Places Right
            var deger2 = context.Blogs.Take(3).OrderByDescending(x => x.Id).ToList();
            ViewData["BenimDegerlerim"] = deger2;
            #endregion

            return View();
        }
        public IActionResult About()
        {
            return View();
        }
    }
}
