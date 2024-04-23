using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Globe.Models
{
    public class create_plog
    {
        [Required]
        public string? Type { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Sup_Title { get; set; }
        [Required]
        public string? Article { get; set; }
        [Required]
        public IFormFile? Img { get; set; }
    }
}
