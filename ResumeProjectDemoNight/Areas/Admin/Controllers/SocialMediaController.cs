using Microsoft.AspNetCore.Mvc;
using ResumeProjectDemoNight.Context;
using ResumeProjectDemoNight.Entities;

namespace ResumeProjectDemoNight.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SocialMediaController : Controller
    {
        private readonly ResumeContext _context;
        public SocialMediaController(ResumeContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.Title = "Sosyal Medya";
            ViewBag.Description = "Sosyal medya bağlantılarınızı yönetin";
            var values = _context.SocialMedias.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Title = "Yeni Sosyal Medya";
            ViewBag.Description = "Yeni sosyal medya hesabı ekleyin";
            return View();
        }

        [HttpPost]
        public IActionResult Create(SocialMedia socialMedia)
        {
            _context.SocialMedias.Add(socialMedia);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var value = _context.SocialMedias.Find(id);
            _context.SocialMedias.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            ViewBag.Title = "Sosyal Medya Düzenle";
            ViewBag.Description = "Sosyal medya bilgilerini güncelleyin";
            var value = _context.SocialMedias.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult Update(SocialMedia socialMedia)
        {
            _context.SocialMedias.Update(socialMedia);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
