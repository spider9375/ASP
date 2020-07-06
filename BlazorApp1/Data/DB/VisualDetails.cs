using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Dealership.Models.DB
{
    public class VisualDetails
    {
        [Key, ForeignKey("Car")]
        public int Id { get; set; }

        public string Color { get; set; }
        public string BodyType { get; set; }
        public int DoorCount { get; set; }
        public bool HasWing { get; set; }

        public virtual Car Car { get; set; }
    }
}
