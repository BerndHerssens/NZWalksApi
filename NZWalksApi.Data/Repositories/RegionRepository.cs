using Microsoft.EntityFrameworkCore;
using NZWalksApi.Data.Entities;


namespace NZWalksApi.Data.Repositories
{
    public class RegionRepository : IRegionRepository
    {
        private NZWalksDBContext _dbContext;

        public RegionRepository(NZWalksDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public RegionEntity GetRegionByID(int id)
        {
            return _dbContext.Regions.Include(x=>x.Walks).SingleOrDefault(x => x.ID == id);
        }

        public IEnumerable<RegionEntity> GetAllRegions()
        {
            return _dbContext.Regions.Include(x => x.Walks);
        }

        public void AddRegion(RegionEntity regionEntity)
        {
            _dbContext.Regions.Add(regionEntity);
            _dbContext.SaveChanges(); //uitvoeren of niet opgeslagen.
        }

        public void DeleteRegionByID(int id)
        {
            RegionEntity regionEntity = new RegionEntity()
            {
                ID = id
            };
            _dbContext.Regions.Remove(regionEntity);
            _dbContext.SaveChanges();
        }

        public void UpdateRegion(int id, RegionEntity regionEntity)
        {
            _dbContext.Regions.Update(regionEntity);
            _dbContext.SaveChanges();
        }
    }
}
