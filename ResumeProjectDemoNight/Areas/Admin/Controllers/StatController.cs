using Microsoft.AspNetCore.Mvc;
using ResumeProjectDemoNight.Context;
using ResumeProjectDemoNight.Entities;

namespace ResumeProjectDemoNight.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class StatController : Controller
    {
        private readonly ResumeContext _context;
        public StatController(ResumeContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.Title = "İstatistikler";
            ViewBag.Description = "İstatistik verilerini yönetin";
            var values = _context.Stats.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Title = "Yeni İstatistik";
            ViewBag.Description = "Yeni istatistik ekleyin";
            return View();
        }

        [HttpPost]
        public IActionResult Create(Stat stat)
        {
            _context.Stats.Add(stat);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var value = _context.Stats.Find(id);
            _context.Stats.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            ViewBag.Title = "İstatistik Düzenle";
            ViewBag.Description = "İstatistik bilgilerini güncelleyin";
            var value = _context.Stats.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult Update(Stat stat)
        {
            _context.Stats.Update(stat);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
