using Microsoft.AspNetCore.Http.HttpResults;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Eventing.Reader;

namespace WebApplication14.Models
{
    public class ReviewModel
    {
        [Key]
        public Guid Guid { get; set; }
        [Required]
        
        public string? Name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        [MaxLength(250)]
        public string? Comments { get; set; }
        
        public int Ratings { get; set; }
        public DateTime? CreatedAt { get; set;}
       

    }
  

}
