using System.Xml.Serialization;

namespace Car_Dealership.Models
{
    [XmlRoot(ElementName = "manufatureDetails")]
    public class ManufactureModel
    {
        [XmlElement("manufacturer")]
        public string Manufacturer { get; set; }
        [XmlElement("model")]
        public string Model { get; set; }
        [XmlElement("year")]
        public int Year { get; set; }
    }
}
