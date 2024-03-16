using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Globe.Data
{
    public class Politlcs
    {
        public int Id { get; set; }
        [Required]
        public string? Type { get; set; }
    }
}
