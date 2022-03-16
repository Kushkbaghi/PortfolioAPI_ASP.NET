using System.ComponentModel.DataAnnotations;

namespace PortfolioAPI.Models
{
    // Handle courses info
    public class Course
    {
        [Key]
        public int Id { get; set; }

        [StringLength(32)]
        [Required(ErrorMessage ="Kursenamn måste vara med!")]
        public string? Name { get; set; }

        [StringLength(2)]
        [Required(ErrorMessage = "Prograssion måste vara med!")]
        public string? Prograssion { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}",
               ApplyFormatInEditMode = true)]
        public DateTime? Start { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}",
               ApplyFormatInEditMode = true)]
        public DateTime? End { get; set; }

        [StringLength(32)]
        public string? CreatedBy { get; set; } = "Okänd";

        [DataType(DataType.Date)]
        public DateTime? CreateAt { get; set; } = DateTime.Now;     
    }
}
