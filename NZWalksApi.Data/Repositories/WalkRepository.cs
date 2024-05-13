using NZWalksApi.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZWalksApi.Data.Repositories
{
    public class WalkRepository : IWalkRepository
    {
        List<WalkEntity> walks = new List<WalkEntity>()
        {
            new WalkEntity()
            {
                ID = 1,
                Name = "Great ocean walk",
                Description = "This is a beautiful walk by the ocean",
                LengthInKm = 20.5,
                Created = DateTime.Now,
                Updated = DateTime.Now,
            },
            new WalkEntity()
            {
                ID = 2,
                Name = "Great forrest walk",
                Description = "This is a beautiful walk in the forrest",
                LengthInKm = 10.5,
                Created = DateTime.Now,
                Updated = DateTime.Now,
            },
            new WalkEntity()
            {
                ID = 3,
                Name = "Great lake walk",
                Description = "This is a beautiful walk by a lake",
                LengthInKm = 15.5,
                Created = DateTime.Now,
                Updated = DateTime.Now,
            },
            new WalkEntity()
            {
                ID = 4,
                Name = "Great mountain walk",
                Description = "This is a beautiful walk in the mountains",
                LengthInKm = 18.5,
                Created = DateTime.Now,
                Updated = DateTime.Now,
            },
        };

        public WalkEntity GetWalkByID(int id)
        {
            return walks.SingleOrDefault(x => x.ID == id);
        }

        public IEnumerable<WalkEntity> GetAllWalks()
        {
            return walks;
        }
    }
}
