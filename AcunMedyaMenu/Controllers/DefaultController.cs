using AcunMedyaMenu.Context;
using AcunMedyaMenu.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaMenu.Controllers
{
    public class DefaultController : Controller
    {

        MenuContext context = new MenuContext();
        public IActionResult Index()
        {
            ViewBag.P1 = "250 yıllık sırlarla dolu özel odamıza hoşgeldiniz. Burası AcunMedya bir odaya sığan kocaman dostluklar, kutlamalar, özel anlaşmalar ve davetleri için Olden tutkunlarına açıldı. Eski bir hikayede yeni uzun sofralar kurmak için rezervasyon yaptırmanız yeterli.";
            ViewBag.P2 = "Geçmişin değerlerini içselleştirip onları bugünle buluşturarak geleceğe taşıyan tohumları atmayı hedefleyen Lacivert, menüsünü bu anlayışla hazırlıyor. Menümüzün klasikleşen lezzetlerine, yeni ve çarpıcı dokunuşlar da ekleyerek mevsimselliği ve yerelin güzelliklerini yansıtan bir çerçeve içinde hareket ediyoruz, daha bilinçli bir tüketimi hedefliyoruz.";
            return View();
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }

        public PartialViewResult PartialScript()
        {
            return PartialView();
        }

        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }

        public PartialViewResult PartialContact()
        {
            return PartialView();
        }

        public PartialViewResult PartialTestimonial()
        {
            return PartialView();
        }
        public PartialViewResult PartialFeature()
        {
            return PartialView();
        }
        public PartialViewResult PartialAbout()
        {
            return PartialView();
        }

        [HttpGet]
        public PartialViewResult CreateBooking()
        {     
            return PartialView();
        }

        [HttpPost]

        public IActionResult CreateBooking (Booking booking)
        {
            booking.Description = "Rezervasyon Alındı";
            context.Bookings.Add(booking);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
