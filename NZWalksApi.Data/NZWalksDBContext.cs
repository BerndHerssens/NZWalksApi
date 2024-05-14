using Microsoft.EntityFrameworkCore;
using NZWalksApi.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
