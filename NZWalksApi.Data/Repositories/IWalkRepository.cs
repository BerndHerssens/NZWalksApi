using NZWalksApi.Data.Entities;

namespace NZWalksApi.Data.Repositories
{
    public interface IWalkRepository
    {
        IEnumerable<WalkEntity> GetAllWalks();
        WalkEntity GetWalkByID(int id);
    }
}