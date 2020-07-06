namespace BlazorApp1.Data.ViewModels
{
    public class CarsTableViewModel
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string EngineType { get; set; }

        public decimal EngineVolume { get; set; }

        public string Year { get; set; }
    }
}
