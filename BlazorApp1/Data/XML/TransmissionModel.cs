using System.Xml.Serialization;

namespace Car_Dealership.Models
{
    [XmlRoot(ElementName = "transmission")]
    public class TransmissionModel
    {
        [XmlElement("type")]
        public string TransmissionType { get; set; }
        [XmlElement("gearCount")]
        public int GearCount { get; set; }
    }
}
