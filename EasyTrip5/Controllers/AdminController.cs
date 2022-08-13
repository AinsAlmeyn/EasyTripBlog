using Microsoft.AspNetCore.Mvc;
using EasyTrip5.Models.Entities;
using System.Linq;

namespace EasyTrip5.Controllers
{
    public class AdminController : Controller
    {
        EasyTripBackEndContext context = new EasyTripBackEndContext();
        public IActionResult Index()
        {
            var degerler = context.Blogs.ToList();
            return View(degerler);
        }

        public IActionResult iletisim()
        {
            return View();
        }

        public IActionResult hakkimizda()
        {
            return View();
        }



        [HttpGet]
        public IActionResult YeniBlog()
        {
            return View();  
        }

        [HttpPost]
        public IActionResult YeniBlog(Blog blog)
        {
            context.Blogs.Add(blog);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult BlogSil(int id)
        {
            var degerler = context.Blogs.Find(id);
            context.Blogs.Remove(degerler);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult BlogGetir(int id)
        {
            var blog = context.Blogs.Find(id);
            return View("BlogGetir",blog);
        }

        [HttpPost]
        public IActionResult BlogGuncelle(Blog blog)
        {
            var degerler = context.Blogs.Find(blog.Id);
            degerler.Aciklama = blog.Aciklama;
            degerler.Baslik = blog.Baslik;
            degerler.Blogimage = blog.Blogimage;
            degerler.Tarih = blog.Tarih;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        
        public IActionResult YorumListesi()
        {
            var degerler = context.Yorumlars.ToList();
            return View(degerler);
        }

        public IActionResult YorumSil(int id)
        {
            var degerler = context.Yorumlars.Find(id);
            context.Yorumlars.Remove(degerler);
            context.SaveChanges();
            return RedirectToAction("YorumListesi");
        }


        public IActionResult YorumGuncelle(int id)
        {
            var yr = context.Yorumlars.Find(id);
            return View("YorumGuncelle",yr);
        }

        [HttpPost]
        public IActionResult YorumGuncelle(Yorumlar yorum)
        {
            var degerler = context.Yorumlars.Find(yorum.Id);
            degerler.Kullaniciadi = yorum.Kullaniciadi;
            degerler.Mail = yorum.Mail;
            degerler.Yorum = yorum.Yorum;
            context.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
    }
}
