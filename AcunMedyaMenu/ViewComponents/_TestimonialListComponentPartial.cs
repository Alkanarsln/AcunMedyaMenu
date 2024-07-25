using AcunMedyaMenu.Context;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaMenu.ViewComponents
{
    public class _TestimonialListComponentPartial : ViewComponent
    {
        MenuContext context = new MenuContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Testimonials.ToList();
            return View(values);
        }
    }
}
