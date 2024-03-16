using System.ComponentModel.DataAnnotations;

namespace Globe.Data
{
    public class Sport
    {
        public int Id { get; set; }
        [Required]
        public string? Type { get; set; }
        [Required]
        public DateTime Time { get; set; }
    }
}
