using Microsoft.AspNetCore.Mvc;
using MyPortflio.DAL.Context;

namespace MyPortflio.ViewComponents
{
    public class _SkillComponentPartial:ViewComponent
    {
        MyPortfolioContext portfolioContext=new MyPortfolioContext();
        public IViewComponentResult Invoke() 
        { 
            var values=portfolioContext.Skills.ToList();
            return View(values); 
        }

    }
}
