using DataLayer.Entities;
using System.ComponentModel.DataAnnotations;

namespace Core.Dtos
{
    public class PlayerStatsRequest
    {
        [Required]
        public int PlayerId { get; set; }
        [Required]
        public Tournament Tournament { get; set; }
    }
}
