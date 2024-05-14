using NZWalksApi.Data.Entities;

namespace NZWalksApi.Data.Repositories
{
    public interface IWalkRepository
    {
        void AddWalk(WalkEntity walkEntity);
        void DeleteWalkByID(int id);
        IEnumerable<WalkEntity> GetAllWalks();
        WalkEntity GetWalkByID(int id);
        List<WalkEntity> GetWalksByRegionID(int regionId);
        void UpdateWalk(int id, WalkEntity walkEntity);
    }
}