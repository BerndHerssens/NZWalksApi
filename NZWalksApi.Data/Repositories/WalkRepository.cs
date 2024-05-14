using NZWalksApi.Data.Entities;

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

        public WalkEntity GetWalkByID(int id)
        {
            return walks.SingleOrDefault(x => x.ID == id);
        }

        public IEnumerable<WalkEntity> GetAllWalks()
        {
            return walks;
        }

        public void AddWalk(WalkEntity walkEntity)
        {
            int ID = walks.Max(x => x.ID) + 1;
            walkEntity.ID = ID;
            walks.Add(walkEntity);
        }

        public void DeleteWalkByID(int id)
        {
            WalkEntity walkEntity = walks.Find(x => x.ID == id);
            walks.Remove(walkEntity);
        }

        public void UpdateWalk(int id, WalkEntity walkEntity)
        {
            WalkEntity entityToUpdate = walks.Find(x => x.ID == id);
            entityToUpdate = walkEntity;
        }

        public List<WalkEntity> GetWalksByRegionID(int regionId)
        {
            return walks.Where(x => x.RegionID == regionId).ToList();
        }
    }
}
