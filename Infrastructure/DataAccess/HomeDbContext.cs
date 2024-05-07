using Domain.Entitys.Home;
using Domain.Entitys.Home.Services;
using Domain.Entitys.Home.SpareParts;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Infrastructure.DataAccess
{
    public class HomeDbContext : DbContext
    {
        public HomeDbContext(DbContextOptions<HomeDbContext> options) : base(options)
        {

        }
        public DbSet<Home> Homes { get; set; }
        public DbSet<HomeRent> HomeRents { get; set; }
        public DbSet<Hotel> Hotels { get; set; }

        public DbSet<HomeBuild> HomeBuilds { get; set; }
        public DbSet<HomeRepair> HomeRepairs { get; set; }
        public DbSet<TechnicalServices> TechnicalServices { get; set; }

        public DbSet<ConstructionMaterials> ConstructionMaterials { get; set; }
        public DbSet<HomeAppliance> HomeAppliances { get; set; }
        public DbSet<HomeEquipment> HomeEquipment { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly( Assembly.GetExecutingAssembly() );
            base.OnModelCreating(modelBuilder);
        }

    }
}
