using Microsoft.AspNetCore.Mvc;
using ResumeProjectDemoNight.Context;
using ResumeProjectDemoNight.Entities;

namespace ResumeProjectDemoNight.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProfileTitleController : Controller
    {
        private readonly ResumeContext _context;
        public ProfileTitleController(ResumeContext context)
        {
            _context = context;
        }

        public IActionResult Update()
        {
            ViewBag.Title = "Profil Başlığı";
            ViewBag.Description = "Ana sayfa profil başlığınızı düzenleyin";
            var value = _context.ProfileTitles.FirstOrDefault();
            return View(value);
        }

        [HttpPost]
        public IActionResult Update(ProfileTitle profileTitle)
        {
            _context.ProfileTitles.Update(profileTitle);
            _context.SaveChanges();
            return RedirectToAction("Update");
        }
    }
}
