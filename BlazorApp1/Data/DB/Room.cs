using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data.DB
{
    public class Room
    {
        [Key]
        public int Id { get; set; }

        public int BedCount { get; set; }

        public decimal Price { get; set; }

        [ForeignKey("Hotel")]
        public int HotelId { get; set; }

        public virtual Hotel Hotel { get; set; }

    }
}
