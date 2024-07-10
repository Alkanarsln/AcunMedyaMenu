using AcunMedyaMenu.Context;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaMenu.ViewComponents.DashboardViewComponents
{
    public class _LastResevationDashboardComponentPartial : ViewComponent
    {
        MenuContext context = new MenuContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Bookings.ToList();
            return View(values);
        }
    }
}
