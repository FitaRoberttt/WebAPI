using DataLayer.Dtos;
using DataLayer.Entities;

namespace DataLayer.Mapping
{
    public static class PlayersMappingExtensions
    {
        public static PlayerDto ToPlayerDto(this Player player)
        {
            if (player == null) return null;

            var result = new PlayerDto();
            result.Id = player.Id;
            result.FullName = player.FirstName + " " + player.LastName;
            result.Position = player.Position;
            result.TeamId = player.TeamId;
            result.Stats = player.Stats.ToStatsDtos();


            return result;
            
        }
    }
}
