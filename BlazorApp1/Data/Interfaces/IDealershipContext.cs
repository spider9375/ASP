using Car_Dealership.Models.DB;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

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
    }
}
