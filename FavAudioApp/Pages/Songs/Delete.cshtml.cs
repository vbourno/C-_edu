using FavAudioApp.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FavAudioApp.Pages.Songs
{
    /// <summary>
    /// Song delete option.
    /// </summary>
    public class DeleteModel : PageModel
    {
        private readonly ISongService songService;

        public DeleteModel(ISongService songService)
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
                int id = int.Parse(Request.Query["id"]);
                songService.DeleteSong(id);
                Response.Redirect("/Songs/Index");
            }
            catch (Exception)
            {
                Response.Redirect("/Error");
            }
        }
    }
}
