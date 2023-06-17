using FavAudioApp.DTO;
using FavAudioApp.Model;
using FavAudioApp.Service;
using FavAudioApp.Validator;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FavAudioApp.Pages.Songs
{
    /// <summary>
    /// Song update page.
    /// </summary>
    public class UpdateModel : PageModel
    {
        private readonly ISongService songService;
        public string errorMessage { get; set; } = "";
        public SongDTO SongDto { get; set; } = new();

        public UpdateModel(ISongService songService)
        {
            this.songService = songService;
        }

        /// <summary>
        /// Song GET.
        /// </summary>
        public void OnGet()
        {
            try
            {
                Song song;

                int id = int.Parse(Request.Query["id"]);
                song = songService.GetSongById(id);

                SongDto = ConvertToDto(song);
            }
            catch (Exception e)
            {
                errorMessage = e.Message;
            }
        }

        /// <summary>
        /// Song POST.
        /// </summary>
        public void OnPost()
        {
            SongDto.Id = int.Parse(Request.Form["id"]);
            SongDto.Title = Request.Form["title"];
            SongDto.Url = Request.Form["url"];
            SongDto.Artist = Request.Form["artist"];
            SongDto.Genre = Request.Form["genre"];

            errorMessage = SongValidator.Validate(SongDto);

            if (!errorMessage.Equals("")) return;

            try
            {
                songService.UpdateSong(SongDto);
                Response.Redirect("/Songs/index");
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Converts Song to DTO.
        /// </summary>
        /// <param name="song"></param>
        /// <returns>dto</returns>
        private SongDTO ConvertToDto(Song song)
        {
            SongDTO dto = new()
            {
                Id = song.Id,
                Title = song.Title,
                Url = song.Url,
                Artist = song.Artist,
                Genre = song.Genre
            };

            return dto;
        }
    }
}
