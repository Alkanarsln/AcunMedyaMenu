using AcunMedyaMenu.Context;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaMenu.ViewComponents
{
    public class _ChefListComponentPartial : ViewComponent
    {
        MenuContext menuContext = new MenuContext();

        public IViewComponentResult Invoke()
        {
            var values = menuContext.Chefs.Where(x => x.Status == true).ToList();
            return View(values);
        }
    }
}
