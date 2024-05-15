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
            List<RegionEntity> regions = new List<RegionEntity>()
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
            modelBuilder.Entity<RegionEntity>().HasData(regions);
        }
    }
}
