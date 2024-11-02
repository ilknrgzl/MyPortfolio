using Microsoft.AspNetCore.Mvc;

namespace MyPortflio.ViewComponents.LayoutViewComponents
{
	public class _LayoutScriptComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{

			return View();
		}
	}
}
