using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Data.Models
{
    public class HotelModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Име е задължително поле")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Град е задължително поле")]
        public int CityId { get; set; }
        public List<RoomModel> Rooms { get; set; }
    }
}
