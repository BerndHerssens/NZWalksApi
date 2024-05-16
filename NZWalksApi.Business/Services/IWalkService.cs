using NZWalksApi.Business.Models;

namespace NZWalksApi.Business.Services
{
    public interface IWalkService
    {
        Task AddWalkAsync(Walk walk);
        Task DeleteWalkByIdAsync(int id);
        Task<IEnumerable<Walk>> GetAllWalksAsync();
        Task<Walk> GetWalkAsync(int id);
        Task UpdateWalkAsync(int id, Walk walk);
    }
}