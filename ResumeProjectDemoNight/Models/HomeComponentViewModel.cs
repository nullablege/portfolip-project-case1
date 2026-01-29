using ResumeProjectDemoNight.Entities;

namespace ResumeProjectDemoNight.Models
{
    public class HomeComponentViewModel
    {
        public List<SocialMedia> SocialMedias { get; set; }
        public List<ProfileTitle> ProfileTitles { get; set; }
        public String? NameSurname { get; set; }
        public string? ImageUrl { get; set; }
    }
}
