using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using NZWalksApi.Business.Models;
using NZWalksApi.Business.Services;

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
        [Route("GetWalk/{id:int}")]
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
    }
}
