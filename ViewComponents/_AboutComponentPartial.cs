using Microsoft.AspNetCore.Mvc;
using MyPortflio.DAL.Context;

namespace MyPortflio.ViewComponents
{
    public class _AboutComponentPartial:ViewComponent
    {
        MyPortfolioContext portfolioContext=new MyPortfolioContext();
        public IViewComponentResult Invoke() 
        { 
            ViewBag.aboutTitle=portfolioContext.Abouts.Select(x => x.Title).ToList().FirstOrDefault();
            ViewBag.aboutSubDescription = portfolioContext.Abouts.Select(x => x.SubDescription).ToList().FirstOrDefault();
            ViewBag.aboutDetails = portfolioContext.Abouts.Select(x => x.Details).ToList().FirstOrDefault();

            return View(); 
        }

    }
}
