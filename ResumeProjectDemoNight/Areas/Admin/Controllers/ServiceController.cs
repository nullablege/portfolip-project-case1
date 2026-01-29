using Microsoft.AspNetCore.Mvc;
using ResumeProjectDemoNight.Context;
using ResumeProjectDemoNight.Entities;

namespace ResumeProjectDemoNight.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServiceController : Controller
    {
        private readonly ResumeContext _context;
        public ServiceController(ResumeContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.Title = "Hizmetler";
            ViewBag.Description = "Sunduğunuz hizmetleri yönetin";
            var values = _context.Services.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Title = "Yeni Hizmet";
            ViewBag.Description = "Yeni hizmet ekleyin";
            return View();
        }

        [HttpPost]
        public IActionResult Create(Service service)
        {
            _context.Services.Add(service);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var value = _context.Services.Find(id);
            _context.Services.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            ViewBag.Title = "Hizmet Düzenle";
            ViewBag.Description = "Hizmet bilgilerini güncelleyin";
            var value = _context.Services.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult Update(Service service)
        {
            _context.Services.Update(service);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
