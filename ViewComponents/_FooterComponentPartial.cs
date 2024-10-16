using Microsoft.AspNetCore.Mvc;

namespace MyPortflio.ViewComponents
{
    public class _FooterComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }

    }
}
