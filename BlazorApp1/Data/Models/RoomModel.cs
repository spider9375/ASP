using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Data.Models
{
    public class RoomModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Брой легла е задължително поле")]
        public int BedCount { get; set; }
        [Required(ErrorMessage = "Цена е задължително поле")]
        public decimal Price { get; set; }
    }
}
