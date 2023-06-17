using FavAudioApp.DTO;
using FavAudioApp.Service;
using FavAudioApp.Validator;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FavAudioApp.Pages.Podcasts
{
    /// <summary>
    /// Podcast create page.
    /// </summary>
    public class CreateModel : PageModel
    {
        private readonly IPodcastService podcastService;
        public string errorMessage { get; set; } = "";
        public PodcastDTO PodcastDto { get; set; } = new PodcastDTO();

        public CreateModel(IPodcastService podcastService)
        {
            this.podcastService = podcastService;
        }
        public void OnGet()
        {
        }

        /// <summary>
        /// Podcast POST
        /// </summary>
        public void OnPost() 
        {
            try
            {
                PodcastDto.Name = Request.Form["name"];
                PodcastDto.Url = Request.Form["url"];
                errorMessage = PodcastValidator.Validate(PodcastDto);

                if (!errorMessage.Equals("")) return;

                podcastService.InsertPodcast(PodcastDto);
                Response.Redirect("/Podcasts/Index");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
