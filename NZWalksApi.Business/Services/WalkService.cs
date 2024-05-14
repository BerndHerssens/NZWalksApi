using NZWalksApi.Business.Models;
using NZWalksApi.Data.Entities;
using NZWalksApi.Data.Repositories;

namespace NZWalksApi.Business.Services
{
    public class WalkService : IWalkService
    {
        private readonly IWalkRepository _walkRepository;

        public WalkService(IWalkRepository walkRepository)
        {
            _walkRepository = walkRepository;
        }

        public Walk GetWalk(int id)
        {
            Walk walk = new Walk();
            WalkEntity walkEntity = _walkRepository.GetWalkByID(id);

            if (walkEntity == null)
            {
                return null;
            }

            walk.ID = walkEntity.ID;
            walk.Name = walkEntity.Name;
            walk.Description = walkEntity.Description;
            walk.LengthInKm = walkEntity.LengthInKm;
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
            WalkEntity walkEntity = new WalkEntity();
            walkEntity.Name = walk.Name;
            walkEntity.Description = walk.Description;
            walkEntity.LengthInKm = walk.LengthInKm;
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
            existingWalkEnt.Name = walk.Name;
            existingWalkEnt.Description = walk.Description;
            existingWalkEnt.LengthInKm = walk.LengthInKm;
            existingWalkEnt.Updated = DateTime.Now;
            _walkRepository.UpdateWalk(id, existingWalkEnt);
        }
    }
}
