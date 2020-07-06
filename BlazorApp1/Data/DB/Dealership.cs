using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Car_Dealership.Models.DB
{
    public class Dealership
    {
        public Dealership()
        {
            this.Cars = new HashSet<Car>();
        }

        [Key]
        public int Id { get; set; }

        public string Address { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}
