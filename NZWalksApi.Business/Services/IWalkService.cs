using NZWalksApi.Business.Models;

namespace NZWalksApi.Business.Services
{
    public interface IWalkService
    {
        Task AddWalkAsync(Walk walk);
        Task DeleteWalkByIdAsync(int id);
        IEnumerable<Walk> GetAllWalks();
        Walk GetWalk(int id);
        Task UpdateWalkAsync(int id, Walk walk);
    }
}