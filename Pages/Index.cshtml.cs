using Microsoft.AspNetCore.Mvc.RazorPages;

namespace portfolio.Pages
{
    public class IndexModel : PageModel
    {


        public string Name { get; set; } = "Amina Yusufova";
        public string Introduction { get; set; } = "I am a passionate full stack developer with expertise in both front-end and back-end technologies. I enjoy crafting seamless and responsive user experiences, while also ensuring robust and scalable server-side logic. With a strong foundation in various programming languages and frameworks, I have the flexibility to adapt to different project requirements and deliver high-quality solutions. My commitment to continuous learning drives me to stay updated with the latest industry trends, allowing me to bring innovative ideas to life. You can explore my projects and connect with me through the links below.\r\n          ";
        public string ProjectsLink { get; set; } = "https://github.com/yusufovamina";
        public string LinkedInLink { get; set; } = "https://www.linkedin.com/in/amina-yusufova-754538261/";

        public void OnGet()
        {
        }
    }
}
