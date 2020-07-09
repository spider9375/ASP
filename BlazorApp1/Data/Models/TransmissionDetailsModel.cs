using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Data.Models
{
    public class TransmissionDetailsModel
    {
        [Required(ErrorMessage = "Изберете скорости")]
        public string TransmissionType { get; set; }

        [Required(ErrorMessage = "Брой скорости е задължително")]
        public int GearCount { get; set; }
    }
}
