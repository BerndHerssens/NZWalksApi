using NZWalksApi.Business.Models;

namespace NZWalksApi.Business.Services
{
    public interface IWalkService
    {
        void AddWalk(Walk walk);
        void DeleteWalkById(int id);
        IEnumerable<Walk> GetAllWalks();
        Walk GetWalk(int id);
        void UpdateWalk(int id, Walk walk);
    }
}