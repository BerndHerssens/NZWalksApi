using NZWalksApi.Data.Repositories;
using NZWalksApi.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZWalksApi.Data.Entities;

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
    }
}
