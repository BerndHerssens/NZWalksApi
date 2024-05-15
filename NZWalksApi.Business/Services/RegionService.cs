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
            _regionRepository.DeleteRegionByID(id);
        }

        public IEnumerable<Region> GetAllRegionsWithWalks()
        {
            IEnumerable<RegionEntity> regionEntities = _regionRepository.GetAllRegions();
            IEnumerable<Region> allRegions = _mapper.Map<IEnumerable<Region>>(regionEntities);
           
            foreach(Region region in allRegions)
            {
                List<WalkEntity> walkEntities = _walkRepository.GetWalksByRegionID(region.ID);
                List<Walk> walks = _mapper.Map<List<Walk>>(walkEntities);
                region.WalksInRegion = walks;
            }
            return allRegions;
        }

        public void UpdateRegion(int id, Region region)
        {
            RegionEntity objectDB = _regionRepository.GetRegionByID(id);

            RegionEntity updatedObject = _mapper.Map<RegionEntity>(region);
            
            objectDB.Name = updatedObject.Name;
            objectDB.BeautyGrade = updatedObject.BeautyGrade;
            objectDB.Walks = updatedObject.Walks;
            objectDB.Description = updatedObject.Description;
            objectDB.Updated = DateTime.Now;
            _regionRepository.UpdateRegion(id,objectDB);
        }
    }
}
