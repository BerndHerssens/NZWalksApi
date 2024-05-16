using NZWalksApi.Data.Entities;

namespace NZWalksApi.Data.Repositories
{
    public interface IWalkRepository
    {
        Task AddWalkAsync(WalkEntity walkEntity);
        Task DeleteWalkByIDAsync(int id);
        IEnumerable<WalkEntity> GetAllWalks();
        WalkEntity GetWalkByID(int id);
        List<WalkEntity> GetWalksByRegionID(int regionId);
        Task UpdateWalkAsync(int id, WalkEntity walkEntity);
    }
}