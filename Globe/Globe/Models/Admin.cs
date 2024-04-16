using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Globe.Models_DB
{
    public class Admin
    {
        public int Id { get; set; }
        [Required]
        
        public string? User_Name { get; set; }
        [Required]
        [PasswordPropertyText]
        public string? Password { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
    }
}
