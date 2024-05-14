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
        public WalksController(IWalkService walkService)
        {
            _walkservice = walkService;
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
        [HttpPost]
        public ActionResult AddWalk(AddWalkDTO addWalk)
        {
            Walk walk = new Walk();
            walk.Name = addWalk.Name;
            walk.Description = addWalk.Description;
            walk.LengthInKm = addWalk.LengthInKm;
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
            Walk walk = new Walk
            {
                Name = updateWalk.Name,
                Description = updateWalk.Description,
                LengthInKm = updateWalk.LengthInKm
            };
            _walkservice.UpdateWalk(id, walk);
            return Created();
        }
    }
}
