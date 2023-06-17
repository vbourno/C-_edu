using FavAudioApp.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FavAudioApp.Pages.Podcasts
{
    /// <summary>
    /// Podcast delete option.
    /// </summary>
    public class DeleteModel : PageModel
    {
        private readonly IPodcastService podcastService;

        public DeleteModel(IPodcastService podcastService)
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
                int id = int.Parse(Request.Query["id"]);
                podcastService.DeletePodcast(id);
                Response.Redirect("/Podcasts/Index");
            }
            catch (Exception)
            {
                Response.Redirect("/Error");
            }
        }
    }
}
