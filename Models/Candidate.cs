using System.ComponentModel.DataAnnotations;
namespace BtkAkademi.Models
{
    public class Candidate
    {
        [Required(ErrorMessage = "E-mail is required.")]
        public String? Email { get; set; } = String.Empty;
        [Required(ErrorMessage = "FirsName is required.")]
        public String? FirstName { get; set; } = String.Empty;
        [Required(ErrorMessage = "LastName required.")]
        public String? LastName { get; set; } = String.Empty;
        public String? FullName => $"{FirstName} {LastName?.ToUpper()}";
        public int? age { get; set; }
        public String? SelectedCourse { get; set; } = String.Empty;
        public DateTime ApplyAt { get; set; }
        public Candidate()
        {
            ApplyAt = DateTime.Now;
        }

    }
}