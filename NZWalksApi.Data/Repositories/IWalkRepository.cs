using NZWalksApi.Data.Entities;

namespace NZWalksApi.Data.Repositories
{
    public interface IWalkRepository
    {
        void AddWalk(WalkEntity walkEntity);
        IEnumerable<WalkEntity> GetAllWalks();
        WalkEntity GetWalkByID(int id);
    }
}