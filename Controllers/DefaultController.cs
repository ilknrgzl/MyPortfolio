using Microsoft.AspNetCore.Mvc;

namespace MyPortflio.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
