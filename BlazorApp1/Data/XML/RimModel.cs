using System.Xml.Serialization;

namespace Car_Dealership.Models
{
    [XmlRoot(ElementName = "rims")]
    public class RimModel
    {
        [XmlElement("color")]
        public string Color { get; set; }
        [XmlElement("brand")]
        public string RimBrand { get; set; }
        [XmlElement("model")]
        public string Model { get; set; }
        [XmlElement("size")]
        public int Size { get; set; }
    }
}
