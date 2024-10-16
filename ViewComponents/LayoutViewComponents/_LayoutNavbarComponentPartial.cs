using Microsoft.AspNetCore.Mvc;

namespace MyPortflio.ViewComponents.LayoutViewComponents
{
	public class _LayoutNavbarComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{

			return View();
		}
	}
}
