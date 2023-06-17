using FavAudioApp.DTO;

namespace FavAudioApp.Validator
{
    /// <summary>
    /// A class that validates the radio parameters inserted by the user.
    /// </summary>
    public class RadioValidator
    {
        private RadioValidator() { }

        public static string Validate(RadioDTO dto)
        {
            if (dto == null || dto is not RadioDTO)
            {
                return "Invalid data";
            }

            if (dto.Name.Length < 2 || dto.Name.Length > 50)
            {
                return "Name shorter than 2 or longer than 50 characters not valid";
            }

            Uri uriResult;
            bool result = Uri.TryCreate(dto.Url, UriKind.Absolute, out uriResult) 
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);

            if (result == false)
            {
                return "URL not valid";
            }

            if (dto.Url.Length > 200)
            {
                return "URL over 200 characters not valid";
            }

            if (dto.Genre!.Length > 50)
            {
                return "Genre over 50 characters not valid";
            }

            if (dto.Region!.Length > 50)
            {
                return "Region over 50 characters not valid";
            }

            return "";
        }
    }
}
