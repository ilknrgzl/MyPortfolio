using Microsoft.AspNetCore.Mvc;

namespace MyPortflio.ViewComponents
{
    public class _TestimonialComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }

    }
}
