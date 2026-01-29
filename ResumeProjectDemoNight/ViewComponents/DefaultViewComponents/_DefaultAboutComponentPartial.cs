using Microsoft.AspNetCore.Mvc;
using ResumeProjectDemoNight.Context;
using ResumeProjectDemoNight.Models;

namespace ResumeProjectDemoNight.ViewComponents.DefaultViewComponents
{
    public class _DefaultAboutComponentPartial : ViewComponent
    {
        private readonly ResumeContext _context;
        public _DefaultAboutComponentPartial(ResumeContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var values = new AboutComponentViewModel
            {
                NameSurname = _context.Abouts.Select(x => x.NameSurname).FirstOrDefault(),
                ImageUrl = _context.Abouts.Select(x => x.ImageUrl).FirstOrDefault(),
                Description = _context.Abouts.Select(x => x.Description).FirstOrDefault(),
                Skills = _context.Skills.ToList(),
                Stats = _context.Stats.ToList()

            };
            return View(values);
        }
    }
}