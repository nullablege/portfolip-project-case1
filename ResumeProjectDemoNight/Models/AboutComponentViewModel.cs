using ResumeProjectDemoNight.Entities;

namespace ResumeProjectDemoNight.Models
{
    public class AboutComponentViewModel
    {
        public string? NameSurname { get; set; }
        public string? ImageUrl { get; set; }
        public string? Description { get; set; }    
        public List<Skill>? Skills { get; set; }
        public List<Stat>? Stats { get; set; } 

    }
}
