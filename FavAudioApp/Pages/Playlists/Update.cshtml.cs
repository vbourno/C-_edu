using FavAudioApp.DTO;
using FavAudioApp.Model;
using FavAudioApp.Service;
using FavAudioApp.Validator;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FavAudioApp.Pages.Playlists
{
    /// <summary>
    /// Playlist create page.
    /// </summary>
    public class UpdateModel : PageModel
    {
        private readonly IPlaylistService playlistService;
        public string errorMessage { get; set; } = "";
        public PlaylistDTO PlaylistDto { get; set; } = new();

        public UpdateModel(IPlaylistService playlistService)
        {
            this.playlistService = playlistService;
        }

        /// <summary>
        /// Playlist GET.
        /// </summary>
        public void OnGet()
        {
            try
            {
                Playlist playlist;

                int id = int.Parse(Request.Query["id"]);
                playlist = playlistService.GetPlaylistById(id);

                PlaylistDto = ConvertToDto(playlist);
            }
            catch (Exception e)
            {
                errorMessage = e.Message;
            }
        }

        /// <summary>
        /// Playlist POST.
        /// </summary>
        public void OnPost()
        {
            PlaylistDto.Id = int.Parse(Request.Form["id"]);
            PlaylistDto.Name = Request.Form["name"];
            PlaylistDto.Url = Request.Form["url"];
            PlaylistDto.Genre = Request.Form["genre"];

            errorMessage = PlaylistValidator.Validate(PlaylistDto);

            if (!errorMessage.Equals("")) return;

            try
            {
                playlistService.UpdatePlaylist(PlaylistDto);
                Response.Redirect("/Playlists/index");
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Converts Playlist to DTO.
        /// </summary>
        /// <param name="playlist"></param>
        /// <returns>dto</returns>
        private PlaylistDTO ConvertToDto(Playlist playlist)
        {
            PlaylistDTO dto = new()
            {
                Id = playlist.Id,
                Name = playlist.Name,
                Url = playlist.Url,
                Genre = playlist.Genre,
            };

            return dto;
        }
    }
}
