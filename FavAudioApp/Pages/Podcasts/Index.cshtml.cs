using FavAudioApp.Model;
using FavAudioApp.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FavAudioApp.Pages.Podcasts
{
    /// <summary>
    /// Podcast index page.
    /// </summary>
    public class IndexModel : PageModel
    {
        private readonly IPodcastService service;
        public List<Podcast> podcasts { get; set; } = new();
        private string errorMessage = "";

        public IndexModel(IPodcastService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Podcast GET.
        /// </summary>
        public void OnGet()
        {
            errorMessage = "";

            try
            {
                podcasts = service.GetAllPodcasts();
            }
            catch (Exception e)
            {
                errorMessage = e.Message;
                Response.Redirect("/Error");
            }
        }
    }
}
