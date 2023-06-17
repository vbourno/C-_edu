using FavAudioApp.Model;
using FavAudioApp.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FavAudioApp.Pages.Playlists
{
    /// <summary>
    /// Playlist Index page.
    /// </summary>
    public class IndexModel : PageModel
    {
        private readonly IPlaylistService service;
        public List<Playlist> playlists { get; set; } = new();
        private string errorMessage = "";

        public IndexModel(IPlaylistService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Playlist GET.
        /// </summary>
        public void OnGet()
        {
            errorMessage = "";

            try
            {
                playlists = service.GetAllPlaylists();
            }
            catch (Exception e)
            {
                errorMessage = e.Message;
                Response.Redirect("/Error");
            }
        }
    }
}
