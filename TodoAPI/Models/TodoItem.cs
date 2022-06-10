using System.ComponentModel.DataAnnotations;

namespace TodoAPI.Models
{
    public class TodoItem
    {
        [Required]
        public string ID { get; set; } = null!;

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public string Notes { get; set; } = null!;

        public bool Done { get; set; }
    }
}
