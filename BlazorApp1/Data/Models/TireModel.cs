using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Data.Models
{
    public class TireModel
    {
        [Required(ErrorMessage = "Марка е задължително")]
        public string TireBrand { get; set; }

        [Required(ErrorMessage = "Сезон е задължително")]
        public string TireSeason { get; set; }

        [Required(ErrorMessage = "Дебелина е задължително")]
        public int Width { get; set; }

        [Required(ErrorMessage = "Диаметър е задължително")]
        public int Diameter { get; set; }
    }
}
