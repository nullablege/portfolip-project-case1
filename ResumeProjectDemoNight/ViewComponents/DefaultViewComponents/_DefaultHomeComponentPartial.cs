using Microsoft.AspNetCore.Mvc;
using ResumeProjectDemoNight.Context;
using ResumeProjectDemoNight.Models;

namespace ResumeProjectDemoNight.ViewComponents.DefaultViewComponents
{
    public class _DefaultHomeComponentPartial:ViewComponent
    {
        private readonly ResumeContext _context;

        public _DefaultHomeComponentPartial(ResumeContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var values = new HomeComponentViewModel
            {
                SocialMedias = _context.SocialMedias.ToList(),
                ProfileTitles = _context.ProfileTitles.ToList(),
                NameSurname = _context.Abouts.Select(x => x.NameSurname).FirstOrDefault(),
                ImageUrl = _context.Abouts.Select(x => x.ImageUrl).FirstOrDefault()
            };
            return View(values);
        }
    }
}
