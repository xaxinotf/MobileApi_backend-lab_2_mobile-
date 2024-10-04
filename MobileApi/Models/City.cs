using System.ComponentModel.DataAnnotations;

namespace MobileApi.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; } = null!;

        public double Distance { get; set; }

        public int Population { get; set; }
    }
}
