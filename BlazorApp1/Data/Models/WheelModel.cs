namespace BlazorApp1.Data.Models
{
    public class WheelModel
    {
        public int Id { get; set; }

        public RimsModel Rims { get; set; } = new RimsModel();

        public TireModel Tires { get; set; } = new TireModel();
    }
}
