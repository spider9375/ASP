using BlazorApp1.Data.DB;
using BlazorApp1.Data.Enums;

namespace BlazorApp1.Data.Models
{
    public class CityModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RegionId { get; set; }
    }
}
