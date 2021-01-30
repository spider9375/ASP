using BlazorApp1.Data.DB;
using BlazorApp1.Data.Interfaces;
using System.Data.Entity;

namespace BlazorApp1
{
    public class HotelsContext : DbContext, IHotelsContext
    {
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Payment> Payments { get; set; }
    }
}
