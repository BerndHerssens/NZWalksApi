using NZWalksApi.Data.Entities;

namespace NZWalksApi.Data.Repositories
{
    public interface IWalkRepository
    {
        Task AddWalkAsync(WalkEntity walkEntity);
        Task DeleteWalkByIDAsync(int id);
        Task<IEnumerable<WalkEntity>> GetAllWalksAsync(int skip, int take, int enterLength);
        Task<WalkEntity> GetWalkByIDAsync(int id);
        Task<List<WalkEntity>> GetWalksByRegionIDAsync(int regionId);
        Task UpdateWalkAsync(int id, WalkEntity walkEntity);
    }
}