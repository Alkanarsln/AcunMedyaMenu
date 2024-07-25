using AcunMedyaMenu.Context;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaMenu.ViewComponents
{
    public class _FoodListComponentPartial : ViewComponent
    {
        MenuContext context = new MenuContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Categories.ToList();
            return View(values);
        }
    }
}
