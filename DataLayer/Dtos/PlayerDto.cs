using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Dtos
{
    public class PlayerDto
    {
        public int Id { get; set; }

        public string FullName { get; set; }
        public int TeamId { get; set; }
        public string Position { get; set; }

        public List<StatsDto> Stats { get; set; }
    }
}
