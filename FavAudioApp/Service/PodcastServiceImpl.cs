using FavAudioApp.DAO;
using FavAudioApp.DTO;
using FavAudioApp.Model;

namespace FavAudioApp.Service
{
    /// <summary>
    /// Podcast service implementation.
    /// </summary>
    public class PodcastServiceImpl : IPodcastService
    {
        private readonly IPodcastDAO dao;

        public PodcastServiceImpl(IPodcastDAO dao)
        {
            this.dao = dao;
        }

        /// <summary>
        /// Inserts podcast.
        /// </summary>
        /// <param name="dto"></param>
        public void InsertPodcast(PodcastDTO? dto)
        {
            if (dto == null) return;

            Podcast podcast = Map(dto);

            try
            {
                dao.Insert(podcast);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }
        }

        /// <summary>
        /// Updates podcast.
        /// </summary>
        /// <param name="dto"></param>
        public void UpdatePodcast(PodcastDTO dto)
        {
            if (dto == null) return;

            Podcast podcast = Map(dto);

            try
            {
                dao.Update(podcast);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }
        }

        /// <summary>
        /// Deletes podcast.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>podcast</returns>
        public Podcast DeletePodcast(int id)
        {
            Podcast podcast;
            try
            {
                podcast = dao.GetById(id);
                if (podcast is null) return null;
                dao.Delete(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }
            return podcast;
        }

        /// <summary>
        /// Returns a podcast by its id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>podcast</returns>
        public Podcast GetPodcastById(int id)
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
        /// Returns all podcasts.
        /// </summary>
        /// <returns>podcasts</returns>
        public List<Podcast> GetAllPodcasts()
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
        /// Converts podcast to DAO.
        /// </summary>
        /// <param name="dto"></param>
        /// <returns>podcast</returns>
        private Podcast Map(PodcastDTO dto)
        {
            if (dto == null) return null;
            Podcast podcast = new Podcast()
            {
                Id = dto.Id,
                Name = dto.Name,
                Url = dto.Url
            };

            return podcast;
        }
    }
}
