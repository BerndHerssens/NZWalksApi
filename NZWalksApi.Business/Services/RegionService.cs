using AutoMapper;
using NZWalksApi.Business.Models;
using NZWalksApi.Data.Entities;
using NZWalksApi.Data.Repositories;

namespace NZWalksApi.Business.Services
{
    public class RegionService : IRegionService
    {
        private readonly IRegionRepository _regionRepository;
        private IMapper _mapper;

        public RegionService(IRegionRepository regionRepository, IMapper mapper)
        {
            _regionRepository = regionRepository;
            _mapper = mapper;
        }

        public Region GetRegion(int id)
        {

            RegionEntity regionEntity = _regionRepository.GetRegionByID(id);

            if (regionEntity == null)
            {
                return null;
            }

            Region region = _mapper.Map<Region>(regionEntity);

            return region;
        }

        public IEnumerable<Region> GetAllRegions()
        {
            IEnumerable<RegionEntity> regionEntities = _regionRepository.GetAllRegions();
            IEnumerable<Region> allRegions = _mapper.Map<IEnumerable<Region>>(regionEntities);
            return allRegions;
        }

        public void AddRegion(Region region)
        {
            RegionEntity regionEntity = _mapper.Map<RegionEntity>(region);
            regionEntity.Created = DateTime.Now;
            regionEntity.Updated = DateTime.Now;
            _regionRepository.AddRegion(regionEntity);
        }

        public void DeleteRegionById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Region> GetAllRegionsWithWalks()
        {
            throw new NotImplementedException();
        }

        public void UpdateRegion(int id, Region region)
        {
            throw new NotImplementedException();
        }
    }
}
