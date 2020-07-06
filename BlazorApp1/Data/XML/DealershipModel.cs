using System.Collections.Generic;
using System.Xml.Serialization;

namespace Car_Dealership.Models
{
    [XmlRoot(Namespace = "https://www.w3schools.com", IsNullable = false, ElementName = "dealership")]
    public class DealershipModel
    {
        [XmlAttribute("id")]
        public int Id { get; set; }

        [XmlAttribute("address")]
        public string Address { get; set; }

        [XmlArray("cars")]
        [XmlArrayItem("car", typeof(CarModel))]
        public List<CarModel> Cars { get; set; }
    }
}
