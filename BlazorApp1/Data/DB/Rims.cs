using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Dealership.Models.DB
{
    public class Rims
    {
        [Key, ForeignKey("Wheels")]
        public int Id { get; set; }
        public string Color { get; set; }
        public string RimBrand { get; set; }
        public string Model { get; set; }
        public int Size { get; set; }

        public virtual Wheels Wheels { get; set; }
    }
}
