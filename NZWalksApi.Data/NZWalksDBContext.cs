using Microsoft.EntityFrameworkCore;
using NZWalksApi.Data.Entities;

namespace NZWalksApi.Data
{
    //Deze klasse communiceert met de database
    public class NZWalksDBContext : DbContext
    {
        // Entities to DB tables
        public DbSet<WalkEntity> Walks { get; set; }

        public DbSet<RegionEntity> Regions { get; set; }

        public NZWalksDBContext(DbContextOptions<NZWalksDBContext> dbContextOptions)
            : base(dbContextOptions) { }

        // Seeding
        protected override void OnModelCreating(ModelBuilder modelBuilder) //seeding: dummy data
        {
            base.OnModelCreating(modelBuilder);

            List<RegionEntity> regions = GenerateRegions(10);
            modelBuilder.Entity<RegionEntity>().HasData(regions);

            List<WalkEntity> walks = GenerateWalks(50);
            modelBuilder.Entity<WalkEntity>().HasData(walks);
        }

        public static void Main(string[] args)
        {
            List<WalkEntity> walks = GenerateWalks(50);
            List<RegionEntity> regions = GenerateRegions(10);

            // Use walks and regions as needed
        }

        private static List<WalkEntity> GenerateWalks(int numWalks)
        {
            var random = new Random();
            var walkEntities = new List<WalkEntity>();

            for (int i = 1; i <= numWalks; i++)
            {
                walkEntities.Add(new WalkEntity()
                {
                    ID = i,
                    Name = $"Walk {i}",
                    Description = $"Description for walk {i}",
                    LengthInKm = random.Next(2, 21), // Generate random length between 2 and 20 km
                    RegionID = random.Next(1, 11), // Generate random region ID between 1 and 10
                    Created = DateTime.Now,
                    Updated = DateTime.Now
                });
            }

            return walkEntities;
        }

        private static List<RegionEntity> GenerateRegions(int numRegions)
        {
            var random = new Random();
            var regionEntities = new List<RegionEntity>();

            for (int i = 1; i <= numRegions; i++)
            {
                regionEntities.Add(new RegionEntity()
                {
                    ID = i,
                    Name = "Region " + i,
                    Description = $"Description for region {i}",
                    BeautyGrade = random.Next(0, 6), // Randomly assign beauty grade
                    Created = DateTime.Now,
                    Updated = DateTime.Now
                });
            }

            return regionEntities;
        }
    }
}