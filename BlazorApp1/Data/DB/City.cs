using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Data.DB
{
    public class City
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        [ForeignKey("Region")]
        public int RegionId { get; set; }

        public virtual Region Region { get; set; }
    }
}
