using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Data.Models
{
    public class EngineDetailsModel
    {
        [Required(ErrorMessage = "Тип двигател е задължително")]
        public string EngineType { get; set; }

        [Required(ErrorMessage = "Обем е задължително")]
        public decimal EngineVolume { get; set; }

        [Required(ErrorMessage = "Конски сили е задължително")]
        public int HorsePower { get; set; }
    }
}
