using FavAudioApp.DTO;

namespace FavAudioApp.Validator
{
    /// <summary>
    /// A class that validates the song parameters inserted by the user.
    /// </summary>
    public class SongValidator
    {
        private SongValidator() { }

        public static string Validate(SongDTO dto)
        {
            if (dto == null || dto is not SongDTO)
            {
                return "Invalid data";
            }

            if (dto.Title.Length < 2 || dto.Title.Length > 100)
            {
                return "Title shorter than 2 or longer than 100 characters not valid";
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

            if (dto.Artist!.Length > 100)
            {
                return "Artist over 100 characters not valid";
            }

            if (dto.Genre!.Length > 20)
            {
                return "Genre over 20 characters not valid";
            }

            return "";
        }
    }
}
