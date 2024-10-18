using System.ComponentModel.DataAnnotations;

//___________________________________________________START OF FILE_______________________________________________\\

namespace PROGPOE2ST10271869.Models
{
    public class Lecturer
    {
        [Key]
        public int LecturerId  {get; set; }
        [Required]
        [Range(0, double.MaxValue)]
        public double HoursWorked {get; set; }
        [Required]
        [Range(0, double.MaxValue)]
        public double HourlyRate { get; set; }
        [Required]
        public string? AdditionalNotes { get; set; }
        [Required]
        public string? DocumentPath { get; set; }

    }
}

//____________________________________________________END OF FILE_________________________________________________\\