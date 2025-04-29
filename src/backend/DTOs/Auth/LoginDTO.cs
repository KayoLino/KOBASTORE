﻿using System.ComponentModel.DataAnnotations;

namespace backend.DTOs.Auth
{
    public class LoginDTO
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(6)]
        public string Senha { get; set; }
    }
}
