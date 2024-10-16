using Microsoft.AspNetCore.Mvc;

namespace MyPortflio.ViewComponents
{
    public class _PortfolioComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }

    }
}
