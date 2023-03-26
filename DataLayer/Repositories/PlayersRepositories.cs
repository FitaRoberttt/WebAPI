using DataLayer.Entities;

namespace DataLayer.Repositories
{
    public class PlayersRepository
    {
        public List<Player> GetAll()
        {
            var results = DbContext.Players;

            return results;
        }

        public Player GetById(int playerId)
        {
            var result = DbContext.Players
                .Where(e => e.Id == playerId)
                .FirstOrDefault();

            return result;
        }
    }
}
