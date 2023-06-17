using FavAudioApp.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FavAudioApp.Pages.Playlists
{
    /// <summary>
    /// Playlist delete option.
    /// </summary>
    public class DeleteModel : PageModel
    {
        private readonly IPlaylistService playlistService;

        public DeleteModel(IPlaylistService playlistService)
        {
            this.playlistService = playlistService;
        }

        /// <summary>
        /// Playlist DELETE.
        /// </summary>
        public void OnGet()
        {
            try
            {
                int id = int.Parse(Request.Query["id"]);
                playlistService.DeletePlaylist(id);
                Response.Redirect("/Playlists/Index");
            }
            catch (Exception)
            {
                Response.Redirect("/Error");
            }
        }
    }
}
