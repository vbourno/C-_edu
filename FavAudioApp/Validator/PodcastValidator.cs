using FavAudioApp.DTO;

namespace FavAudioApp.Validator
{
    /// <summary>
    /// A class that validates the podcast parameters inserted by the user.
    /// </summary>
    public class PodcastValidator
    {
        private PodcastValidator() { }

        public static string Validate(PodcastDTO dto)
        {
            if (dto == null || dto is not PodcastDTO)
            {
                return "Invalid data";
            }

            if (dto.Name.Length < 2 || dto.Name.Length > 200)
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

            return "";
        }
    }
}
