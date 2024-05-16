using Microsoft.EntityFrameworkCore;
using NZWalksApi.Data.Entities;

namespace NZWalksApi.Data.Repositories
{
    public class WalkRepository : IWalkRepository
    {
        private NZWalksDBContext _dbContext;

        public WalkRepository(NZWalksDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<WalkEntity> GetWalkByIDAsync(int id)
        {
            return await _dbContext.Walks
                .Include(x => x.Region)
                .SingleOrDefaultAsync(x => x.ID == id);
        }

        public async Task<IEnumerable<WalkEntity>> GetAllWalksAsync()
        {
            return await _dbContext.Walks.Include(x => x.Region).ToListAsync();
        }

        public async Task AddWalkAsync(WalkEntity walkEntity)
        {
            await _dbContext.Walks.AddAsync(walkEntity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateWalkAsync(int id, WalkEntity walkEntity)
        {
            _dbContext.Walks.Update(walkEntity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteWalkByIDAsync(int id)
        {
            WalkEntity walkEntity = new WalkEntity { ID = id };
            _dbContext.Walks.Remove(walkEntity);
            await _dbContext.SaveChangesAsync();
        }



        public async Task<List<WalkEntity>> GetWalksByRegionIDAsync(int regionId)
        {
            return await _dbContext.Walks.Where(x => x.RegionID == regionId).ToListAsync();
        }
    }
}