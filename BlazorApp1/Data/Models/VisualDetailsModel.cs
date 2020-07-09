using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Data.Models
{
    public class VisualDetailsModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Цвят е задължително")]
        public string Color { get; set; }

        [Required(ErrorMessage = "Купе е задължително")]
        public string BodyType { get; set; }

        [Required(ErrorMessage = "Брой врати е задължително")]
        public int DoorCount { get; set; }

        [Required(ErrorMessage = "Спойлер е задължително")]
        public bool HasWing { get; set; }
    }
}
