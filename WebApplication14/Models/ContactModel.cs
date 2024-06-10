using System.ComponentModel.DataAnnotations;

namespace WebApplication14.Models
{
    public class ContactModel

    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        [Required]
        public string? PhoneNumber { get; set; }
        [Required]
        [MaxLength(100)]
        public string? Message { get; set; }
    }
}
