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
            return _dbContext.Walks.SingleOrDefault(x => x.ID == id);
        }

        public IEnumerable<WalkEntity> GetAllWalks()
        {
            return _dbContext.Walks;
        }

        public void AddWalk(WalkEntity walkEntity)
        {
            _dbContext.Walks.Add(walkEntity);
            _dbContext.SaveChanges();
        }

        public void UpdateWalk(int id, WalkEntity walkEntity)
        {
            _dbContext.Walks.Update(walkEntity);
            _dbContext.SaveChanges();
        }

        public void DeleteWalkByID(int id)
        {
            WalkEntity walkEntity = new WalkEntity { ID = id };
            _dbContext.Walks.Remove(walkEntity);
            _dbContext.SaveChanges();
        }

    

        public List<WalkEntity> GetWalksByRegionID(int regionId)
        {
            return _dbContext.Walks.Where(x => x.RegionID == regionId).ToList();
        }
    }
}