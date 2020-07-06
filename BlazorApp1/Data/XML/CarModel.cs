using System.Xml.Serialization;

namespace Car_Dealership.Models
{
    [XmlRoot(ElementName = "car")]
    public class CarModel
    {
        [XmlAttribute("id")]
        public int Id { get; set; }
        [XmlElement("manufactureDetails")]
        public ManufactureModel ManufactureDetails { get; set; }
        [XmlElement("engineDetails")]
        public EngineDetailsModel EngineDetails { get; set; }
        [XmlElement("visualDetails")]
        public VisualDetailsModel VisualDetails { get; set; }
        [XmlElement("wheels")]
        public WheelModel Wheels { get; set; }
        [XmlElement("transmission")]
        public TransmissionModel Transmission { get; set; }
        [XmlElement("price")]
        public int Price { get; set; }
    }
}
