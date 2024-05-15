using Microsoft.EntityFrameworkCore;
using NZWalksApi.Data.Entities;

namespace NZWalksApi.Data
{
    public class NZWalksDBContext : DbContext
    {
        //Deze klasse communiceert met de database!!

        public DbSet<WalkEntity> Walks { get; set; }
        public DbSet<RegionEntity> Regions { get; set; }

        public NZWalksDBContext(DbContextOptions<NZWalksDBContext> dbContextOptions)
            : base(dbContextOptions)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) //seeding: dummy data 
        {
            base.OnModelCreating(modelBuilder);

            List<RegionEntity> regions = GenerateRegions();
            modelBuilder.Entity<RegionEntity>().HasData(regions);

            List<WalkEntity> walks = GenerateWalks();
            modelBuilder.Entity<WalkEntity>().HasData(walks);
        }

        private List<WalkEntity> GenerateWalks()
        {
            return new List<WalkEntity>()
            {
                new WalkEntity()
                {
                    ID = 1,
                    Name = "Great ocean walk",
                    Description = "This is a beautiful walk by the ocean",
                    LengthInKm = 20.5,
                    RegionID = 1,
                    Created = DateTime.Now,
                    Updated = DateTime.Now,
                },
                new WalkEntity()
                {
                    ID = 2,
                    Name = "Great forrest walk",
                    Description = "This is a beautiful walk in the forrest",
                    LengthInKm = 10.5,
                    RegionID = 1,
                    Created = DateTime.Now,
                    Updated = DateTime.Now,
                },
                new WalkEntity()
                {
                    ID = 3,
                    Name = "Great lake walk",
                    Description = "This is a beautiful walk by a lake",
                    LengthInKm = 15.5,
                    RegionID = 1,
                    Created = DateTime.Now,
                    Updated = DateTime.Now,
                },
                new WalkEntity()
                {
                    ID = 4,
                    Name = "Great mountain walk",
                    Description = "This is a beautiful walk in the mountains",
                    LengthInKm = 18.5,
                    RegionID = 2,
                    Created = DateTime.Now,
                    Updated = DateTime.Now,
                },
            };
        }

        private List<RegionEntity> GenerateRegions()
        {
            return new List<RegionEntity>()
            {
                new RegionEntity()
                {
                    ID = 1,
                    Name = "Auckland",
                    Description = "They make Path of Exile here...",
                    BeautyGrade = BeautyGrade.MrPropreClean,
                    Created = DateTime.Now,
                    Updated = DateTime.Now,
                },
                new RegionEntity()
                {
                    ID = 2,
                    Name = "Kosciuszko",
                    Description = "Best day hike for active families 13km (8 miles), 4-5 hours, easy to moderate.",
                    BeautyGrade = BeautyGrade.Normal,
                    Created = DateTime.Now,
                    Updated = DateTime.Now,
                }
            };
        }
    }
}
