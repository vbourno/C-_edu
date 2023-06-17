using FavAudioApp.DTO;
using FavAudioApp.Service;
using FavAudioApp.Validator;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FavAudioApp.Pages.Playlists
{
    /// <summary>
    /// Playlist insert page.
    /// </summary>
    public class CreateModel : PageModel
    {
        private readonly IPlaylistService playlistService;
        public string errorMessage { get; set; } = "";
        public PlaylistDTO PlaylistDto { get; set; } = new PlaylistDTO();

        public CreateModel(IPlaylistService playlistService)
        {
            this.playlistService = playlistService;
        }
        public void OnGet()
        {
        }

        /// <summary>
        /// Playlist POST.
        /// </summary>
        public void OnPost() 
        {
            try
            {
                PlaylistDto.Name = Request.Form["name"];
                PlaylistDto.Url = Request.Form["url"];
                PlaylistDto.Genre = Request.Form["genre"];
                errorMessage = PlaylistValidator.Validate(PlaylistDto);

                if (!errorMessage.Equals("")) return;

                playlistService.InsertPlaylist(PlaylistDto);
                Response.Redirect("/Playlists/Index");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
