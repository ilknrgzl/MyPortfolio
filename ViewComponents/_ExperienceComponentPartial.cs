using Microsoft.AspNetCore.Mvc;
using MyPortflio.DAL.Context;

namespace MyPortflio.ViewComponents
{
    public class _ExperienceComponentPartial:ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();

        public IViewComponentResult Invoke() { 
             var values= portfolioContext.Experiences.ToList();
                return View(values); }

    }

}
