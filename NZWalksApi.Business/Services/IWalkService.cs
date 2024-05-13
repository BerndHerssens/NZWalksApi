using NZWalksApi.Business.Models;

namespace NZWalksApi.Business.Services
{
    public interface IWalkService
    {
        IEnumerable<Walk> GetAllWalks();
        Walk GetWalk(int id);
    }
}