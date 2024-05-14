using NZWalksApi.Data.Entities;

namespace NZWalksApi.Data.Repositories
{
    public interface IWalkRepository
    {
        void AddWalk(WalkEntity walkEntity);
        void DeleteWalkByID(int id);
        IEnumerable<WalkEntity> GetAllWalks();
        WalkEntity GetWalkByID(int id);
        void UpdateWalk(int id, WalkEntity walkEntity);
    }
}