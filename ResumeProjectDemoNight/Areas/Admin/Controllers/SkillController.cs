using Microsoft.AspNetCore.Mvc;
using ResumeProjectDemoNight.Context;
using ResumeProjectDemoNight.Entities;

namespace ResumeProjectDemoNight.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SkillController : Controller
    {
        private readonly ResumeContext _context;
        public SkillController(ResumeContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.Title = "Yetenekler";
            ViewBag.Description = "Teknik yeteneklerinizi yönetin";
            var values = _context.Skills.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Title = "Yeni Yetenek";
            ViewBag.Description = "Yeni yetenek ekleyin";
            return View();
        }

        [HttpPost]
        public IActionResult Create(Skill skill)
        {
            _context.Skills.Add(skill);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var value = _context.Skills.Find(id);
            _context.Skills.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            ViewBag.Title = "Yetenek Düzenle";
            ViewBag.Description = "Yetenek bilgilerini güncelleyin";
            var value = _context.Skills.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult Update(Skill skill)
        {
            _context.Skills.Update(skill);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
