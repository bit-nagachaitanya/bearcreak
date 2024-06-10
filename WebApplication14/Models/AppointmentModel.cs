using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication14.Models
{
    public class AppointmentModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? First_name { get; set; }
        public string? Last_name { get;  set; }
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        public string? Phonenumber { get; set; }
        public string? Services { get; set; }
            
    }
}
