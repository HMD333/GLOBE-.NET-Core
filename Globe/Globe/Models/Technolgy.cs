using System.ComponentModel.DataAnnotations;

namespace Globe.Models
{
    public class Technolgy
    {
        public int Id { get; set; }
        [Required]
        public string? Type { get; set; }
    }
}
