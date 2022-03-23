using System.ComponentModel.DataAnnotations;

namespace PortfolioAPI.Models
{
    // Handle jobb info
    public class Job
    {
        [Key]
        public int Id { get; set; }

        [StringLength(32)]
        [Required(ErrorMessage = "Jobbtitel måste vara med!")]
        public string? Title { get; set; }

        [StringLength(32)]
        [Required(ErrorMessage = "Arbetsort måste vara med!")]
        public string? Place { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",
                   ApplyFormatInEditMode = true)]
        public DateTime? Start { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",
               ApplyFormatInEditMode = true)]
        public DateTime? End { get; set; }

        public string? CreatedBy { get; set; } = "Okänd";

    
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{yyyy-MM-dd}",
               ApplyFormatInEditMode = true)]
        public DateTime? CreateAt { get; set; } = DateTime.Now;
    }
}
