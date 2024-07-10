using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaMenu.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
