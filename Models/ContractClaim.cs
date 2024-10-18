using System.ComponentModel.DataAnnotations;

namespace PROGPOE2ST10271869.Models
{
    public class ContractClaim
    {
        [Key]
        public int Id { get; set; }
        public string LecturerId { get; set; }  // foreign key to lecturer
        public int HoursWorked { get; set; }
        public decimal HourlyRate { get; set; }
        public string AdditionalNotes { get; set; }
        public DateTime SubmissionDate { get; set; }
        public bool IsApproved { get; set; }
    }
}
