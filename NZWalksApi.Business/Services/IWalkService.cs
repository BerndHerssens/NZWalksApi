using NZWalksApi.Business.Models;

namespace NZWalksApi.Business.Services
{
    public interface IWalkService
    {
        Task AddWalkAsync(Walk walk);

        Task DeleteWalkByIdAsync(int id);

        Task<IEnumerable<Walk>> GetAllWalksAsync(int page, int take, int enterLength);

        Task<Walk> GetWalkAsync(int id);

        Task UpdateWalkAsync(int id, Walk updatedWalk);
    }
}