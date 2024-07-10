using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaMenu.ViewComponents.DashboardViewComponents
{
    public class _NavbarDashboardComponentPartial : ViewComponent
    {
        public  IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
