using FavAudioApp.Model;

namespace FavAudioApp.DAO
{
    /// <summary>
    /// DAO interface for Radio.
    /// </summary>
    public interface IRadioDAO
    {
        void Insert(Radio radio);
        void Update(Radio radio);
        void Delete(int id);
        Radio GetById(int id);
        List<Radio> GetAll();
    }
}
