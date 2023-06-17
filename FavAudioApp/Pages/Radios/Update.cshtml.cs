using FavAudioApp.DTO;
using FavAudioApp.Model;
using FavAudioApp.Service;
using FavAudioApp.Validator;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FavAudioApp.Pages.Radios
{
    /// <summary>
    /// Radio update page.
    /// </summary>
    public class UpdateModel : PageModel
    {
        private readonly IRadioService radioService;
        public string errorMessage { get; set; } = "";
        public RadioDTO RadioDto { get; set; } = new();

        public UpdateModel(IRadioService radioService)
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
                Radio radio;

                int id = int.Parse(Request.Query["id"]);
                radio = radioService.GetRadioById(id);

                RadioDto = ConvertToDto(radio);
            }
            catch (Exception e)
            {
                errorMessage = e.Message;
            }
        }

        /// <summary>
        /// Radio POST.
        /// </summary>
        public void OnPost()
        {
            RadioDto.Id = int.Parse(Request.Form["id"]);
            RadioDto.Name = Request.Form["name"];
            RadioDto.Url = Request.Form["url"];
            RadioDto.Genre = Request.Form["genre"];
            RadioDto.Region = Request.Form["region"];

            errorMessage = RadioValidator.Validate(RadioDto);

            if (!errorMessage.Equals("")) return;

            try
            {
                radioService.UpdateRadio(RadioDto);
                Response.Redirect("/Radios/index");
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Converts Radio to DTO.
        /// </summary>
        /// <param name="radio"></param>
        /// <returns>dto</returns>
        private RadioDTO ConvertToDto(Radio radio)
        {
            RadioDTO dto = new()
            {
                Id = radio.Id,
                Name = radio.Name,
                Url = radio.Url,
                Genre = radio.Genre,
                Region = radio.Region
            };

            return dto;
        }
    }
}
