using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Dealership.Models.DB
{
    public class Wheels
    {
        [Key, ForeignKey("Car")]
        public int Id { get; set; }

        public virtual Rims Rims { get; set; }

        public virtual Tires Tires { get; set; }

        public virtual Car Car { get; set; }
    }
}
