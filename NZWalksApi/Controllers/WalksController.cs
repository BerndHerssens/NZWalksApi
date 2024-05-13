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
    }
}
