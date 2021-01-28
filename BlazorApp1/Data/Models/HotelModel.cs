using System.Collections.Generic;

namespace BlazorApp1.Data.Models
{
    public class HotelModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CityId { get; set; }
        public List<RoomModel> Rooms { get; set; }
    }
}
