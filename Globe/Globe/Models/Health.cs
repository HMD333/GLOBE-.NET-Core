using System.ComponentModel.DataAnnotations;

namespace Globe.Data
{
    public class Health
    {
        public int Id { get; set; }
        [Required]
        public string? Type { get; set; }
    }
}
