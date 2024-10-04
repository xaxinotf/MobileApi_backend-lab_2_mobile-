using System.ComponentModel.DataAnnotations;

namespace MobileApi.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; } = null!;

        public string Email { get; set; } = null!;
    }
}
