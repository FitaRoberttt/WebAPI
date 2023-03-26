using DataLayer.Entities;

namespace Core.Dtos;

public class StatsByPlayer
{
    public int? PlayerId { get; set; }

    public string PlayerCompleteName { get; set; }

    public List<StatsDto> Stats { get; set; }

    public StatsByPlayer(Player player)
    {
        PlayerId = player?.Id;
        PlayerCompleteName = player?.FirstName + " " + player?.LastName;

        if (player?.Stats != null)
        {
            Stats = player.Stats
                .Select(s => new StatsDto
                {
                    GoalsScored = s.GoalsScored,
                    Assists = s.Assists,
                    Appearances = s.Appearances,
                    YellowCards = s.YellowCards,
                    RedCards = s.RedCards,
                    Tournament = s.Tournament


                })
                .ToList();
        }
    }

}

