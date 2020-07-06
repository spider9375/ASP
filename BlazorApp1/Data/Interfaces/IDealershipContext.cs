using BlazorApp1.Data.DB;
using Car_Dealership.Models.DB;
using System.Data.Entity;

namespace BlazorApp1.Data.Interfaces
{
    public interface IDealershipContext
    {
        public DbSet<Dealership> Dealerships { get; set; }

        public DbSet<Car> Cars { get; set; }

        public DbSet<EngineDetails> EngineDetails { get; set; }

        public DbSet<ManufactureDetails> ManufactureDetails { get; set; }

        public DbSet<Rims> Rims { get; set; }

        public DbSet<Tires> Tires { get; set; }

        public DbSet<TransmissionDetails> TransmissionsDetails { get; set; }

        public DbSet<VisualDetails> VisualDetails { get; set; }

        public DbSet<Wheels> Wheels { get; set; }

        public DbSet<Schema> Schemas { get; set; }

    }
}
