using Microsoft.AspNetCore.Mvc;

namespace MyPortflio.ViewComponents.LayoutViewComponents
{
	public class _LayoutSidebarComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{

			return View();
		}
	}
}
