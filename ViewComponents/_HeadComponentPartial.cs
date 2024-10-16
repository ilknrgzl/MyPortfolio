using Microsoft.AspNetCore.Mvc;

namespace MyPortflio.ViewComponents
{
    public class _HeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }

}
