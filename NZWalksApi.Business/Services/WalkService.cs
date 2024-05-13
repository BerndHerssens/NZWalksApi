using NZWalksApi.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZWalksApi.Business.Services
{
    public class WalkService
    {
        private readonly IWalkRepository _walkRepository;

        public WalkService(IWalkRepository walkRepository)
        {
            _walkRepository = walkRepository;
        }

        public WalkService GetWalk(int id) 
        {

            return null;
        }
    }
}
