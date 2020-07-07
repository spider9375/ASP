namespace BlazorApp1.Data.Models
{
    public class CarModel
    {
        public int Id { get; set; }
        public ManufactureDetailsModel ManufactureDetails { get; set; } = new ManufactureDetailsModel();
        public EngineDetailsModel EngineDetails { get; set; } = new EngineDetailsModel();
        public VisualDetailsModel VisualDetails { get; set; } = new VisualDetailsModel();
        public WheelModel Wheels { get; set; } = new WheelModel();
        public TransmissionDetailsModel Transmission { get; set; } = new TransmissionDetailsModel();
        public int Price { get; set; }
    }
}
