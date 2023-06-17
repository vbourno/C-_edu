using FavAudioApp.Model;
using FavAudioApp.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FavAudioApp.Pages.Radios
{
    /// <summary>
    /// Radio index page.
    /// </summary>
    public class IndexModel : PageModel
    {
        private readonly IRadioService service;
        public List<Radio> radios { get; set; } = new();
        private string errorMessage = "";

        public IndexModel(IRadioService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Radio GET.
        /// </summary>
        public void OnGet()
        {
            errorMessage = "";

            try
            {
                radios = service.GetAllRadios();
            }
            catch (Exception e)
            {
                errorMessage = e.Message;
                Response.Redirect("/Error");
            }
        }
    }
}
