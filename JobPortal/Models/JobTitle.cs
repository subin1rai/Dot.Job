using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace JobPortal.Models
{
    public class JobTitle
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(40)]
        [DisplayName("Name :")]
        public string Name { get; set; }

        [Required]
        [StringLength(40)]
        [DisplayName("Job Title :")]
        public string Title { get; set; }

        [Required]
        [StringLength(40)]
        [DisplayName("Location :")]
        public string Location { get; set; }

        [Required]
        [StringLength(40)]
        [DisplayName("Salary :")]
        public string Salary { get; set; }
    }
}
