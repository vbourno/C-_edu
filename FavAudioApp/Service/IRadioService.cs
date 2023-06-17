using FavAudioApp.DTO;
using FavAudioApp.Model;

namespace FavAudioApp.Service
{
    /// <summary>
    /// Radio service interface.
    /// </summary>
    public interface IRadioService
    {
        void InsertRadio(RadioDTO? dto);
        void UpdateRadio(RadioDTO dto);
        Radio DeleteRadio(int id);
        Radio GetRadioById(int id);
        List<Radio> GetAllRadios();
    }
}
