using Microsoft.AspNetCore.Mvc;

namespace MyPortflio.Controllers
{
	public class ExperienceController : Controller
	{
		public IActionResult ExperienceList()
		{
			return View();
		}
	}
}
