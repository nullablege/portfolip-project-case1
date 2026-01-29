using Microsoft.AspNetCore.Mvc;
using ResumeProjectDemoNight.Context;
using ResumeProjectDemoNight.Entities;

namespace ResumeProjectDemoNight.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutController : Controller
    {
        private readonly ResumeContext _context;
        public AboutController(ResumeContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.Title = "Hakkımda";
            ViewBag.Description = "Profil bilgilerinizi yönetin";
            var values = _context.Abouts.ToList();
            ViewBag.ProfileTitles = _context.ProfileTitles.ToList();
            ViewBag.SocialMedias = _context.SocialMedias.ToList();
            ViewBag.Testimonials = _context.Testimonials.ToList();
            return View(values);
        }

        [HttpPost]
        public IActionResult Update(About about)
        {
            _context.Abouts.Update(about);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
