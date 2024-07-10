using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaMenu.ViewComponents.DashboardViewComponents
{
    public class _HeadDashboardViewComponents : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
