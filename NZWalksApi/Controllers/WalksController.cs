using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NZWalksApi.Business.Models;
using NZWalksApi.Business.Services;
using NZWalksApi.DTO;

namespace NZWalksApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WalksController : ControllerBase
    {
        private IWalkService _walkservice;
        private IMapper _mapper;
        public WalksController(IWalkService walkService, IMapper mapper)
        {
            _walkservice = walkService;
            _mapper = mapper;
        }
        [HttpGet]
        //[Route("GetWalk/{id:int}")]
        public ActionResult<Walk> GetSpecificWalk(int id)
        {
            Walk walk = _walkservice.GetWalk(id);
            if (walk == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(walk);
            }
        }
        [HttpGet]
        [Route("GetAllWalks")]
        public ActionResult<Walk> GetAllWalks()
        {
            IEnumerable<Walk> walks = _walkservice.GetAllWalks();
            if (walks == null || walks.Count() == 0 )
            {
                return NotFound();
            }
            else
            {
                return Ok(walks);
            }
        }
        [HttpPost]
        public ActionResult AddWalk(AddWalkDTO addWalk)
        {
            Walk walk = _mapper.Map<Walk>(addWalk);
            _walkservice.AddWalk(walk);
            return Created();
        }
        [HttpDelete]
        public ActionResult DeleteWalk(int id)
        {
            _walkservice.DeleteWalkById(id);
            return Created();
        }

        [HttpPut]
        public ActionResult UpdateWalk(int id, UpdateWalkDTO updateWalk)
        {
            Walk walk = _mapper.Map<Walk>(updateWalk);
            _walkservice.UpdateWalk(id, walk);
            return Created();
        }
    }
}
