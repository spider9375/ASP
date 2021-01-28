using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BlazorApp1.Pages;

namespace BlazorApp1.Data.DB
{
    public class Region
    {
        public Region()
        {
            this.Cities = new HashSet<City>();
        }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}
