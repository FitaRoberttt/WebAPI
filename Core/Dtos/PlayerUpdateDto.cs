﻿using System.ComponentModel.DataAnnotations;

namespace Core.Dtos
{
    public class PlayerUpdateDto
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string FirstName { get; set; }

        [Required, MaxLength(100)]
        public string LastName { get; set; }


    }
}
