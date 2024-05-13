using NZWalksApi.Business.Models;

namespace NZWalksApi.Business.Services
{
    public interface IWalkService
    {
        void AddWalk(Walk walk);
        IEnumerable<Walk> GetAllWalks();
        Walk GetWalk(int id);
    }
}