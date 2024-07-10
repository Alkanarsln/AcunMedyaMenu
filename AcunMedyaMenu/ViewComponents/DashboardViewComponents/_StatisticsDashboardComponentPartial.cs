using AcunMedyaMenu.Context;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaMenu.ViewComponents.DashboardViewComponents
{
    public class _StatisticsDashboardComponentPartial : ViewComponent
    {
        MenuContext context = new MenuContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.productCount = context.Products.Count();
            ViewBag.activeProductCount = context.Products.Where(x => x.Status == true).Count();
            ViewBag.avgProductPrice = context.Products.Average(x => x.Price);   

            Random rnd = new Random();
            int count = rnd.Next(10, 31);
            ViewBag.bookingCount = count;
            return View();
        }
    }
}
