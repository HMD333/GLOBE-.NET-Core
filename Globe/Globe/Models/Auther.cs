using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Globe.Data
{
    public class Auther
    {
        public int Id { get; set; }
        [Required]
        public string? Fist_Name { get; set; }
        [Required]
        public string? Last_Name { get; set; }
        public sbyte? Faverat { get; set; }
        [Required]
        public string? Username { get; set; }
        [Required]
        [PasswordPropertyText]
        public string? Password { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }

    }
}
