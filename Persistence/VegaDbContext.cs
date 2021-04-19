using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vega.Models;

namespace vega.Persistence
{
    public class VegaDbContext : DbContext
    {
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Make> Makes { get; set; }
        public DbSet<Feature> Features { get; set; }
        public VegaDbContext(DbContextOptions<VegaDbContext> options)
            : base(options)
        {
            //System.Configuration.ConfiguratoinManager
        }


        // this method helps create unique id from combination of both VehicleId and FeatureId so in the VehicleFeature table we
        // we will not need an id field which will be redundant
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VehicleFeature>().HasKey(vf =>
            new { vf.VehicleId, vf.FeatureId });
        }
    }
}
