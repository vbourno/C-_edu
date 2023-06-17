using FavAudioApp.Model;
using FavAudioApp.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FavAudioApp.Pages.Songs
{
    /// <summary>
    /// Song index page.
    /// </summary>
    public class IndexModel : PageModel
    {
        private readonly ISongService service;
        public List<Song> songs { get; set; } = new();
        private string errorMessage = "";

        public IndexModel(ISongService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Song GET.
        /// </summary>
        public void OnGet()
        {
            errorMessage = "";

            try
            {
                songs = service.GetAllsongs();
            }
            catch (Exception e)
            {
                errorMessage = e.Message;
                Response.Redirect("/Error");
            }
        }
    }
}
