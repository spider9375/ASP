using System.Xml.Serialization;

namespace Car_Dealership.Models
{
    [XmlRoot(ElementName = "wheels")]
    public class WheelModel
    {
        [XmlElement("rims")]
        public RimModel Rims { get; set; }
        [XmlElement("tires")]
        public TireModel Tires { get; set; }
    }
}
