using EasyTrip5.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace EasyTrip5.Controllers
{
    public class BlogController : Controller
    {
        EasyTripBackEndContext context = new EasyTripBackEndContext();
        public IActionResult Index()
        {
            by.Deger1 = context.Blogs.ToList();
            by.Deger3 = context.Blogs.Take(3).OrderByDescending(x => x.Tarih).ToList();
            return View(by);
        }

        BlogYorum by = new BlogYorum();
        public IActionResult BlogDetail(int id)
        {
            TempData["veri"] = id;
            by.Deger1 = context.Blogs.Where(x => x.Id == id).ToList();
            by.Deger2 = context.Yorumlars.Where(x => x.BlogsNavigation.Id == id).ToList();
            return View(by);
        }


        [HttpPost]
        public IActionResult YorumYap(Yorumlar yorumlar)
        {
            var data = TempData["veri"];
            yorumlar.Blogs = Convert.ToInt32(data);
            context.Yorumlars.Add(yorumlar);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}