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

        public Player GetByIdWithStats(int playerId, Tournament tournament)
        {
            var result = DbContext.Players
                .Select(e => new Player
                {

                    FirstName = e.FirstName,
                    LastName = e.LastName,
                    Id = e.Id,
                    Position = e.Position,
                    TeamId = e.TeamId,
                    Stats = e.Stats.
                    Where(s => s.Tournament == tournament)
                    .OrderByDescending(s => s.GoalsScored)
                    .ToList()
                })
                .FirstOrDefault(e => e.Id == playerId);
            

            return result;
        }

      


    }
}
