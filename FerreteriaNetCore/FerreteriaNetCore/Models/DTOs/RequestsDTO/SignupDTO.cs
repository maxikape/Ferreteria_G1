using System;

namespace FerreteriaNetCore.Models.DTOs.RequestsDTO
{
    public class SignupDTO
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string PasswordConfirmation { get; set; }

        public string Email { get; set; }

        public string Bithdate { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }
    }
}