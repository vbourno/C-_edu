using FavAudioApp.DTO;
using FavAudioApp.Model;
using FavAudioApp.Service;
using FavAudioApp.Validator;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FavAudioApp.Pages.Podcasts
{
    /// <summary>
    /// Podcast update page.
    /// </summary>
    public class UpdateModel : PageModel
    {
        private readonly IPodcastService podcastService;
        public string errorMessage { get; set; } = "";
        public PodcastDTO PodcastDto { get; set; } = new();

        public UpdateModel(IPodcastService podcastService)
        {
            this.podcastService = podcastService;
        }

        /// <summary>
        /// Podcast GET.
        /// </summary>
        public void OnGet()
        {
            try
            {
                Podcast podcast;

                int id = int.Parse(Request.Query["id"]);
                podcast = podcastService.GetPodcastById(id);

                PodcastDto = ConvertToDto(podcast);
            }
            catch (Exception e)
            {
                errorMessage = e.Message;
            }
        }

        /// <summary>
        /// Podcast POST
        /// </summary>
        public void OnPost()
        {
            PodcastDto.Id = int.Parse(Request.Form["id"]);
            PodcastDto.Name = Request.Form["name"];
            PodcastDto.Url = Request.Form["url"];

            errorMessage = PodcastValidator.Validate(PodcastDto);

            if (!errorMessage.Equals("")) return;

            try
            {
                podcastService.UpdatePodcast(PodcastDto);
                Response.Redirect("/Podcasts/index");
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Converts Podcast to DTO.
        /// </summary>
        /// <param name="podcast"></param>
        /// <returns>dto</returns>
        private PodcastDTO ConvertToDto(Podcast podcast)
        {
            PodcastDTO dto = new()
            {
                Id = podcast.Id,
                Name = podcast.Name,
                Url = podcast.Url
            };

            return dto;
        }
    }
}
