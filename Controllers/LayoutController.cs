using Microsoft.AspNetCore.Mvc;

namespace MyPortflio.Controllers
{
	public class LayoutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
