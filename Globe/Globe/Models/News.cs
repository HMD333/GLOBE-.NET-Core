using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Globe.Models
{
    public class News
    {
        public int Id { get; set; }
        [Required]
        public string? Type { get; set; }
        [Required]
        public int Type_id { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Sup_Title { get; set; }
        [Required]
        public string? Article { get; set; }
        [Required]
        public string? Img_path { get; set; }
        [Required]
        public DateTime Date_Time { get; set; }
        [Required]
        public string? Au_Type { get; set; }
        [Required]
        public int AU_id { get; set; }

    }
}
