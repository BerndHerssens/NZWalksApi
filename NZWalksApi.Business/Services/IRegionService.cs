using NZWalksApi.Business.Models;

namespace NZWalksApi.Business.Services
{
    public interface IRegionService
    {
        void AddRegion(Region region);
        void DeleteRegionById(int id);
        IEnumerable<Region> GetAllRegions();
        IEnumerable<Region> GetAllRegionsWithWalks();
        Region GetRegion(int id);
        void UpdateRegion(int id, Region region);
    }
}
