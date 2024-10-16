using Microsoft.AspNetCore.Mvc;
using MyPortflio.DAL.Context;

namespace MyPortflio.ViewComponents
{
    public class _FeatureComponentPartial:ViewComponent
    {
        MyPortfolioContext portfolioContext=new MyPortfolioContext();
        public IViewComponentResult Invoke() 
        { 
            var values=portfolioContext.Features.ToList();
            return View(values); 
        }
    }
}
