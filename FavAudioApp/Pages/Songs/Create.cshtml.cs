using FavAudioApp.DTO;
using FavAudioApp.Service;
using FavAudioApp.Validator;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FavAudioApp.Pages.Songs
{
    /// <summary>
    /// Song create page.
    /// </summary>
    public class CreateModel : PageModel
    {
        private readonly ISongService songService;
        public string errorMessage { get; set; } = "";
        public SongDTO SongDto { get; set; } = new SongDTO();

        public CreateModel(ISongService songService)
        {
            this.songService = songService;
        }
        public void OnGet()
        {
        }

        /// <summary>
        /// Song POST.
        /// </summary>
        public void OnPost()
        {
            try
            {
                SongDto.Title = Request.Form["title"];
                SongDto.Url = Request.Form["url"];
                SongDto.Artist = Request.Form["artist"];
                SongDto.Genre = Request.Form["genre"];
                errorMessage = SongValidator.Validate(SongDto);

                if (!errorMessage.Equals("")) return;

                songService.InsertSong(SongDto);
                Response.Redirect("/Songs/Index");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
