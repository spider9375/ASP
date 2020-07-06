using System.Xml.Serialization;

namespace Car_Dealership.Models
{
    [XmlRoot(ElementName = "tires")]
    public class TireModel
    {
        [XmlElement("brand")]
        public string TireBrand { get; set; }
        [XmlElement("season")]
        public string TireSeason { get; set; }
        [XmlElement("width")]
        public int Width { get; set; }
        [XmlElement("diameter")]
        public int Diameter { get; set; }
    }
}
