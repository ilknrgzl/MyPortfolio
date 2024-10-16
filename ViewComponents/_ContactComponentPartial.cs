using Microsoft.AspNetCore.Mvc;

namespace MyPortflio.ViewComponents
{
    public class _ContactComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
