using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaMenu.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
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

        public PartialViewResult PartialCarousel()
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

        public PartialViewResult PartialTeam()
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
        public PartialViewResult PartialMenu()
        {
            return PartialView();
        }
    }
}
