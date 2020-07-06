namespace BlazorApp1.Data.Models
{
    public class CarModel
    {
        public int Id { get; set; }
        public ManufactureDetailsModel ManufactureDetails { get; set; }
        public EngineDetailsModel EngineDetails { get; set; }
        public VisualDetailsModel VisualDetails { get; set; }
        public WheelModel Wheels { get; set; }
        public TransmissionDetailsModel Transmission { get; set; }
        public int Price { get; set; }
    }
}
