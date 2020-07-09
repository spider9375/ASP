using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Data.Models
{
    public class ManufactureDetailsModel
    {
        [Required(ErrorMessage = "Марка е задължително")]
        public string Manufacturer { get; set; }

        [Required(ErrorMessage = "Модел е задължително")]
        public string Model { get; set; }

        [Required(ErrorMessage = "Година е задължително")]
        public int Year { get; set; }
    }
}
