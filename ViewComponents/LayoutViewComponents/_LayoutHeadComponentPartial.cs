using Microsoft.AspNetCore.Mvc;

namespace MyPortflio.ViewComponents.LayoutViewComponents
{
	public class _LayoutHeadComponentPartial: ViewComponent
	{
		public IViewComponentResult Invoke()
		{

		return View(); }
	}
}
