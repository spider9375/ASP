using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Dealership.Models.DB
{
    public class TransmissionDetails
    {
        [Key, ForeignKey("Car")]
        public int Id { get; set; }

        public string TransmissionType { get; set; }
        public int GearCount { get; set; }

        public virtual Car Car { get; set; }
    }
}
