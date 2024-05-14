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

        public Walk GetWalk(int id)
        {
            Walk walk = new Walk();
            WalkEntity walkEntity = _walkRepository.GetWalkByID(id);

            if (walkEntity == null)
            {
                return null;
            }

            walk = _mapper.Map<Walk>(walkEntity);

            return walk;
        }

        public IEnumerable<Walk> GetAllWalks()
        {
            List<Walk> walks = new List<Walk>();
            IEnumerable<WalkEntity> walkEntities = _walkRepository.GetAllWalks();
            // Map the WalkEntities to Walk models
            foreach (WalkEntity walkEntity in walkEntities)
            {
                Walk walk = new Walk();
                walk.ID = walkEntity.ID;
                walk.Name = walkEntity.Name;
                walk.Description = walkEntity.Description;
                walk.LengthInKm = walkEntity.LengthInKm;
                walks.Add(walk);
            }
            return walks;
        }

        public void AddWalk(Walk walk)
        {
            WalkEntity walkEntity = _mapper.Map<WalkEntity>(walk);
            walkEntity.Created = DateTime.Now;
            walkEntity.Updated = DateTime.Now;
            _walkRepository.AddWalk(walkEntity);
        }

        public void DeleteWalkById(int id)
        {
            _walkRepository.DeleteWalkByID(id);
        }

        public void UpdateWalk(int id, Walk walk)
        {
            WalkEntity existingWalkEnt = _walkRepository.GetWalkByID(id);
            existingWalkEnt = _mapper.Map<WalkEntity>(walk);
            existingWalkEnt.Updated = DateTime.Now;
            _walkRepository.UpdateWalk(id, existingWalkEnt);
        }
    }
}
