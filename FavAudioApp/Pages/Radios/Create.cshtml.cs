using FavAudioApp.DTO;
using FavAudioApp.Service;
using FavAudioApp.Validator;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FavAudioApp.Pages.Radios
{
    /// <summary>
    /// Radio create page.
    /// </summary>
    public class CreateModel : PageModel
    {
        private readonly IRadioService radioService;
        public string errorMessage { get; set; } = "";
        public RadioDTO RadioDto { get; set; } = new RadioDTO();

        public CreateModel(IRadioService radioService)
        {
            this.radioService = radioService;
        }
        public void OnGet()
        {
        }

        /// <summary>
        /// Radio POST
        /// </summary>
        public void OnPost() 
        {
            try
            {
                RadioDto.Name = Request.Form["name"];
                RadioDto.Url = Request.Form["url"];
                RadioDto.Genre = Request.Form["genre"];
                RadioDto.Region = Request.Form["region"];
                errorMessage = RadioValidator.Validate(RadioDto);

                if (!errorMessage.Equals("")) return;

                radioService.InsertRadio(RadioDto);
                Response.Redirect("/Radios/Index");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
