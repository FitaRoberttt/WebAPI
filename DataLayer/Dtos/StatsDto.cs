using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Dtos
{
    public class StatsDto
    {
        public int GoalsScored { get; set; }
        public int Assists { get; set; }
        public int Appearances { get; set; }
        public int YellowCards { get; set; }
        public int RedCards { get; set; }
        public Tournament Tournament { get; set; }
    }
}
