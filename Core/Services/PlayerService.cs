using Core.Dtos;
using DataLayer.Entities;
using DataLayer.Repositories;

namespace Core.Services
{
    public class PlayerService
    {
        public PlayersRepository playersRepository { get; set; }

        public PlayerService(PlayersRepository playersRepository)
        {
            this.playersRepository = playersRepository;
        }

        public List<Player> GetAll()
        {
            var results = playersRepository.GetAll();

            return results;
        }
        public Player GetById(int playerId)
        {
            var result = playersRepository.GetById(playerId);

            return result;
        }
        static void Main() { }
        public bool EditName(PlayerUpdateDto payload)
        {
            if (payload == null || payload.FirstName==null || payload.LastName==null )
            {
                return false;
            }
            var result = playersRepository.GetById(payload.Id);

            if (result == null) return false;

            result.FirstName = payload.FirstName;
            result.LastName = payload.LastName;

            return true;
        }
    }
}
