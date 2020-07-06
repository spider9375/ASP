using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Dealership.Models.DB
{
    public class EngineDetails
    {
        [Key, ForeignKey("Car")]
        public int Id { get; set; }
        public string EngineType { get; set; }
        public decimal EngineVolume { get; set; }
        public int HorsePower { get; set; }

        public virtual Car Car { get; set; }
    }
}
