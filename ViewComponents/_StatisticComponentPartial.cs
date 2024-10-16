using Microsoft.AspNetCore.Mvc;

namespace MyPortflio.ViewComponents
{
    public class _StatisticComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
