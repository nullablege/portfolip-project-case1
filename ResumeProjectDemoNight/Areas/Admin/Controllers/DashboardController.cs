using Microsoft.AspNetCore.Mvc;
using ResumeProjectDemoNight.Context;

namespace ResumeProjectDemoNight.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        private readonly ResumeContext _context;
        public DashboardController(ResumeContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.Title = "Dashboard";
            ViewBag.Description = "Portföy yönetim panelinize hoş geldiniz";
            
            ViewBag.TotalProjects = _context.Portfolios.Count();
            ViewBag.ActiveProjects = _context.Portfolios.Count(p => p.Status);
            ViewBag.TotalMessages = _context.Messages.Count();
            ViewBag.UnreadMessages = _context.Messages.Count(m => !m.IsRead);
            ViewBag.TotalSkills = _context.Skills.Count();
            ViewBag.TotalServices = _context.Services.Count();
            ViewBag.TotalExperiences = _context.Experiences.Count();
            ViewBag.TotalTestimonials = _context.Testimonials.Count();
            
            return View();
        }
    }
}
