using FavAudioApp.DAO;
using FavAudioApp.DTO;
using FavAudioApp.Model;

namespace FavAudioApp.Service
{
    /// <summary>
    /// Radio service implementation.
    /// </summary>
    public class RadioServiceImpl : IRadioService
    {
        private readonly IRadioDAO dao;

        public RadioServiceImpl(IRadioDAO dao) 
        {
            this.dao = dao;
        }

        /// <summary>
        /// Inserts radio.
        /// </summary>
        /// <param name="dto"></param>
        public void InsertRadio(RadioDTO? dto)
        {
            if (dto == null) return;

            Radio radio = Map(dto);

            try
            {
                dao.Insert(radio);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }
        }

        /// <summary>
        /// Updates radio.
        /// </summary>
        /// <param name="dto"></param>
        public void UpdateRadio(RadioDTO dto)
        {
            if (dto == null) return;

            Radio radio = Map(dto);

            try
            {
                dao.Update(radio);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }
        }

        /// <summary>
        /// Deletes radio.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>radio</returns>
        public Radio DeleteRadio(int id)
        {
            Radio radio;
            try
            {
                radio = dao.GetById(id);
                if (radio is null) return null;
                dao.Delete(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }
            return radio;
        }

        /// <summary>
        /// Returns radio by its id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>radio</returns>
        public Radio GetRadioById(int id)
        {
            try
            {
                return dao.GetById(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }
        }

        /// <summary>
        /// Returns all radios.
        /// </summary>
        /// <returns>radios</returns>
        public List<Radio> GetAllRadios()
        {
            try
            {
                return dao.GetAll();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }
        }

        /// <summary>
        /// Converts radio to DAO.
        /// </summary>
        /// <param name="dto"></param>
        /// <returns>radio</returns>
        private Radio Map(RadioDTO dto)
        {
            if (dto == null) return null;
            Radio radio = new Radio()
            {
                Id = dto.Id,
                Name = dto.Name,
                Url = dto.Url,
                Genre = dto.Genre,
                Region = dto.Region
            };

            return radio;
        }
    }
}
