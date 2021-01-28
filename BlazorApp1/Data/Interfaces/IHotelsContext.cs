using BlazorApp1.Data.DB;
using System.Data.Entity;

namespace BlazorApp1.Data.Interfaces
{
    public interface IHotelsContext
    {
        public DbSet<Hotel> Hotels { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<Region> Regions { get; set; }

    }
}
