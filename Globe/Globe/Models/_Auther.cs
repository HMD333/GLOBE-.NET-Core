using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Globe.Data
{
    public class _Auther
    {
        [Required]
        public string? First_Name { get; set; }
        [Required]
        public string? Last_Name { get; set; }
        [Required]
        public string? Username { get; set; }
        [Required]
        public string? Password { get; set; }
        [Required]
        public string? RePassword { get; set; }
        [Required]
        public string? Email { get; set; }

    }
}
