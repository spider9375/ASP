using System.Xml.Serialization;

namespace Car_Dealership.Models
{
    [XmlRoot(ElementName = "engineDetails")]
    public class EngineDetailsModel
    {
        [XmlElement("engineType")]
        public string EngineType { get; set; }
        [XmlElement("engineVolume")]
        public decimal EngineVolume { get; set; }
        [XmlElement("horsePower")]
        public int HorsePower { get; set; }
    }
}
