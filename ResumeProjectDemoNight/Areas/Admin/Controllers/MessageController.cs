using Microsoft.AspNetCore.Mvc;
using ResumeProjectDemoNight.Context;

namespace ResumeProjectDemoNight.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MessageController : Controller
    {
        private readonly ResumeContext _context;
        public MessageController(ResumeContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.Title = "Mesajlar";
            ViewBag.Description = "İletişim formundan gelen mesajları görüntüleyin";
            var values = _context.Messages.OrderByDescending(m => m.SendDate).ToList();
            return View(values);
        }

        public IActionResult Delete(int id)
        {
            var value = _context.Messages.Find(id);
            _context.Messages.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult MarkAsRead(int id)
        {
            var value = _context.Messages.Find(id);
            value.IsRead = true;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
