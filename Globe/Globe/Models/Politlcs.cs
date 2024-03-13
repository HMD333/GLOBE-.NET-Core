using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Globe.Models
{
    public class Politlcs
    {
        public int Id { get; set; }
        [Required]
        public string? Type { get; set; }
    }
}
