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

        public async Task<RegionEntity> GetRegionByIDAsync(int id)
        {
            return await _dbContext.Regions.Include(x => x.Walks).SingleOrDefaultAsync(x => x.ID == id);
        }

        public async Task<IEnumerable<RegionEntity>> GetAllRegionsAsync()
        {
            return await _dbContext.Regions.Include(x => x.Walks).ToArrayAsync();
        }

        public async Task AddRegionAsync(RegionEntity regionEntity)
        {
            await _dbContext.Regions.AddAsync(regionEntity);
            await _dbContext.SaveChangesAsync(); //uitvoeren of niet opgeslagen.
        }

        public async Task DeleteRegionByIDAsync(int id)
        {
            RegionEntity regionEntity = new RegionEntity()
            {
                ID = id
            };
            _dbContext.Regions.Remove(regionEntity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateRegionAsync(int id, RegionEntity regionEntity)
        {
            _dbContext.Regions.Update(regionEntity);
            await _dbContext.SaveChangesAsync();
        }
    }
}