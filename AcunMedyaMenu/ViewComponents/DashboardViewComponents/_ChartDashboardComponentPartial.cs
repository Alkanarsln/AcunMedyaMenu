using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaMenu.ViewComponents.DashboardViewComponents
{
    public class _ChartDashboardComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
