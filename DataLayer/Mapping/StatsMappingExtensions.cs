using DataLayer.Dtos;
using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Mapping
{
    public static class StatsMappingExtensions
    {
        public static List<StatsDto> ToStatsDtos(this List<Stats> statss)
        {
            var result = statss.Select(s => s.ToStatsDto()).ToList();

            return result;
            
        }

        public static StatsDto ToStatsDto(this Stats stats)
        {
            if (stats == null) return null;

            var result = new StatsDto();
            result.GoalsScored = stats.GoalsScored;
            result.Assists = stats.Assists;
            result.Appearances = stats.Appearances;
            result.YellowCards = stats.YellowCards;
            result.RedCards = stats.RedCards;
            result.Tournament = stats.Tournament;
            

            return result;
        }
    }
}
