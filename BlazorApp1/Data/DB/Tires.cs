using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Dealership.Models.DB
{
    public class Tires
    {
        [Key, ForeignKey("Wheels")]
        public int Id { get; set; }
        public string TireBrand { get; set; }
        public string TireSeason { get; set; }
        public int Width { get; set; }
        public int Diameter { get; set; }

        public virtual Wheels Wheels { get; set; }
    }
}
