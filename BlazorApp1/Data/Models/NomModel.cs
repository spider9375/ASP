using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Data.Models
{
    public class NomModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Име е задължително поле")]
        public string Name { get; set; }
    }
}
