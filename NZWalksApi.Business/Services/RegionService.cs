using AutoMapper;
using NZWalksApi.Business.Models;
using NZWalksApi.Data.Entities;
using NZWalksApi.Data.Repositories;

namespace NZWalksApi.Business.Services
{
    public class RegionService : IRegionService
    {
        private readonly IRegionRepository _regionRepository;
        private IWalkRepository _walkRepository;
        private IMapper _mapper;

        public RegionService(IRegionRepository regionRepository, IMapper mapper, IWalkRepository walkRepository)
        {
            _regionRepository = regionRepository;
            _mapper = mapper;
            _walkRepository = walkRepository;
        }

        public async Task<Region> GetRegionAsync(int id)
        {

            RegionEntity regionEntity = await _regionRepository.GetRegionByIDAsync(id);

            if (regionEntity == null)
            {
                return null;
            }

            Region region = _mapper.Map<Region>(regionEntity);

            return region;
        }

        public async Task<IEnumerable<Region>> GetAllRegionsAsync()
        {
            IEnumerable<RegionEntity> regionEntities = await _regionRepository.GetAllRegionsAsync();
            IEnumerable<Region> allRegions = _mapper.Map<IEnumerable<Region>>(regionEntities);
            return allRegions;
        }

        public async Task AddRegionAsync(Region region)
        {
            RegionEntity regionEntity = _mapper.Map<RegionEntity>(region);
            regionEntity.Created = DateTime.Now;
            regionEntity.Updated = DateTime.Now;
            await _regionRepository.AddRegionAsync(regionEntity);
        }

        public async Task DeleteRegionByIdAsync(int id)
        {
            await _regionRepository.DeleteRegionByIDAsync(id);
        }

        public async Task<IEnumerable<Region>> GetAllRegionsWithWalksAsync()
        {
            IEnumerable<RegionEntity> regionEntities = await _regionRepository.GetAllRegionsAsync();
            IEnumerable<Region> allRegions = _mapper.Map<IEnumerable<Region>>(regionEntities);

            foreach (Region region in allRegions)
            {
                List<WalkEntity> walkEntities = await _walkRepository.GetWalksByRegionIDAsync(region.ID);
                List<Walk> walks = _mapper.Map<List<Walk>>(walkEntities);
                region.WalksInRegion = walks;
            }
            return allRegions;
        }

        public async Task UpdateRegionAsync(int id, Region region)
        {
            RegionEntity objectDB = await _regionRepository.GetRegionByIDAsync(id);

            RegionEntity updatedObject = _mapper.Map<RegionEntity>(region);

            objectDB.Name = updatedObject.Name;
            objectDB.BeautyGrade = updatedObject.BeautyGrade;
            objectDB.Walks = updatedObject.Walks;
            objectDB.Description = updatedObject.Description;
            objectDB.Updated = DateTime.Now;
            await _regionRepository.UpdateRegionAsync(id, objectDB);
        }
    }
}
