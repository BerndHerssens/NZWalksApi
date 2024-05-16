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

        public WalkEntity GetWalkByID(int id)
        {
            return _dbContext.Walks
                .Include(x => x.Region)
                .SingleOrDefault(x => x.ID == id);
        }

        public IEnumerable<WalkEntity> GetAllWalks()
        {
            return _dbContext.Walks.Include(x => x.Region);
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



        public List<WalkEntity> GetWalksByRegionID(int regionId)
        {
            return _dbContext.Walks.Where(x => x.RegionID == regionId).ToList();
        }
    }
}