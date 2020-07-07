using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Dealership.Models.DB
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Dealership")]
        public int DealershipId { get; set; }

        public virtual ManufactureDetails ManufactureDetails { get; set; }

        public virtual EngineDetails EngineDetails { get; set; }

        public virtual VisualDetails VisualDetails { get; set; }

        public virtual Wheels Wheels { get; set; }
        public virtual TransmissionDetails TransmissionDetails { get; set; }

        public virtual Dealership Dealership { get; set; }
        public int Price { get; set; }
    }
}
