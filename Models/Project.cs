using System.ComponentModel.DataAnnotations;

namespace PortfolioAPI.Models
{
    // Handle project info
    public class Project
    {
        [Key]
        public int Id { get; set; }

        [StringLength(32)]
        [Required(ErrorMessage = "Projektnamn måste vara med!")]
        public string? Name { get; set; }

        [StringLength(500)]
        [Required(ErrorMessage = "Beskrivning måste vara med!")]
        public string? Description { get; set; }

        [StringLength(64)]
        [Required(ErrorMessage = "Projektlänk måste vara med!")]
        public string? Url { get; set; }

        [StringLength(225)]
        public string? ImageName { get; set; }

        [StringLength(32)]
        public string? CreatedBy { get; set; } = "Okänd";

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",
               ApplyFormatInEditMode = true)]
        public DateTime? CreateAt { get; set; } = DateTime.Now;
    }
}