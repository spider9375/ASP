using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Data.Models
{
    public class DealershipModel
    {
        public int? Id { get; set; }

        [Required(ErrorMessage = "Моля въведете адрес.")]
        public string Address { get; set; }

        public List<CarModel> Cars { get; set; } = new List<CarModel>();
    }
}
