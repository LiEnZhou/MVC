using System.ComponentModel.DataAnnotations;

namespace homework0522.Models
{
    public class Makeup
    {

        // 驗證屬性
        // Validation Attribute
        [Required]
        [Range(1, 1000)]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Range(0, 100)]
        public int price { get; set; }
        [Required]
        [Range(1, 100)]
        public string? color { get; set; }
    }
}
