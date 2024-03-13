using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Globe.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string? First_Name { get; set; }
        [Required]
        public string? Last_Name { get; set; }
        [Required]
        public string? Usar_Name { get; set; }
        public sbyte? Faverat { get; set;}
        [Required]
        [PasswordPropertyText]
        public string? password { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
    }
}
