using FavAudioApp.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FavAudioApp.Pages.Radios
{
    /// <summary>
    /// Radio delete option.
    /// </summary>
    public class DeleteModel : PageModel
    {
        private readonly IRadioService radioService;

        public DeleteModel(IRadioService radioService)
        {
            this.radioService = radioService;
        }

        /// <summary>
        /// Radio GET.
        /// </summary>
        public void OnGet()
        {
            try
            {
                int id = int.Parse(Request.Query["id"]);
                radioService.DeleteRadio(id);
                Response.Redirect("/Radios/Index");
            }
            catch (Exception)
            {
                Response.Redirect("/Error");
            }
        }
    }
}
