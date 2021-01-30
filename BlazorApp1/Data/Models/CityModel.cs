using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Data.Models
{
    public class CityModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Име е задължително поле")]

        public string Name { get; set; }
        [Required(ErrorMessage = "Регион е задължително поле")]
        public int RegionId { get; set; }
    }
}
