using NZWalksApi.Data.Entities;

namespace NZWalksApi.Data.Repositories
{
    public class RegionRepository : IRegionRepository
    {
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

        public RegionEntity GetRegionByID(int id)
        {
            return regions.SingleOrDefault(x => x.ID == id);
        }

        public IEnumerable<RegionEntity> GetAllRegions()
        {
            return regions;
        }

        public void AddRegion(RegionEntity regionEntity)
        {
            int ID = regions.Max(x => x.ID) + 1;
            regionEntity.ID = ID;
            regions.Add(regionEntity);
        }

        public void DeleteRegionByID(int id)
        {
            RegionEntity regionEntity = regions.Find(x => x.ID == id);
            regions.Remove(regionEntity);
        }

        public void UpdateRegion(int id, RegionEntity regionEntity)
        {
            RegionEntity entityToUpdate = regions.Find(x => x.ID == id);
            entityToUpdate = regionEntity;
        }
    }
}
