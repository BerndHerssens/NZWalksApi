using AutoMapper;
using NZWalksApi.Business.Models;
using NZWalksApi.Data.Entities;
using NZWalksApi.Data.Repositories;

namespace NZWalksApi.Business.Services
{
    public class WalkService : IWalkService
    {
        private readonly IWalkRepository _walkRepository;
        private IMapper _mapper;

        public WalkService(IWalkRepository walkRepository, IMapper mapper)
        {
            _walkRepository = walkRepository;
            _mapper = mapper;
        }

        public async Task<Walk> GetWalkAsync(int id)
        {
            Walk walk = new Walk();
            WalkEntity walkEntity = await _walkRepository.GetWalkByIDAsync(id);

            if (walkEntity == null)
            {
                return null;
            }

            walk = _mapper.Map<Walk>(walkEntity);

            return walk;
        }

        public async Task<IEnumerable<Walk>> GetAllWalksAsync(int page, int take, int enterLength)
        {
            int skip = (page - 1) * take;

            List<Walk> walks = new List<Walk>();
            IEnumerable<WalkEntity> walkEntities = await _walkRepository.GetAllWalksAsync(skip, take, enterLength);

            // Map the WalkEntities to Walk models
            walks = _mapper.Map<List<Walk>>(walkEntities);
            return walks;
        }

        public async Task AddWalkAsync(Walk walk)
        {
            WalkEntity walkEntity = _mapper.Map<WalkEntity>(walk);
            walkEntity.Created = DateTime.Now;
            walkEntity.Updated = DateTime.Now;
            await _walkRepository.AddWalkAsync(walkEntity);
        }

        public async Task DeleteWalkByIdAsync(int id)
        {
            await _walkRepository.DeleteWalkByIDAsync(id);
        }

        public async Task UpdateWalkAsync(int id, Walk walk)
        {
            WalkEntity existingWalk = await _walkRepository.GetWalkByIDAsync(id);
            WalkEntity updatedWalkEntity = _mapper.Map<WalkEntity>(walk);

            existingWalk.Description = updatedWalkEntity.Description;
            existingWalk.Region = updatedWalkEntity.Region; // TODO
            existingWalk.RegionID = updatedWalkEntity.RegionID;
            existingWalk.LengthInKm = updatedWalkEntity.LengthInKm;
            existingWalk.Name = updatedWalkEntity.Name;

            existingWalk.Updated = DateTime.Now;
            await _walkRepository.UpdateWalkAsync(id, existingWalk);

        }
    }
}
