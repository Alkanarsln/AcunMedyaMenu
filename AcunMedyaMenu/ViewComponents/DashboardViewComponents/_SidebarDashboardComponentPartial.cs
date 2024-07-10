using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaMenu.ViewComponents.DashboardViewComponents
{
    public class _SidebarDashboardComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
