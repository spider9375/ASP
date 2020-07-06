using System.Xml.Serialization;

namespace Car_Dealership.Models
{
    [XmlRoot(ElementName = "visualDetails")]
    public class VisualDetailsModel
    {
        [XmlElement("color")]
        public string Color { get; set; }
        [XmlElement("bodyType")]
        public string BodyType { get; set; }
        [XmlElement("doorCount")]
        public int DoorCount { get; set; }
        [XmlElement("hasWing")]
        public bool HasWing { get; set; }
    }
}
