using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZWalksApi.Business.Models;
using NZWalksApi.Business.Services;
using NZWalksApi.DTO;

namespace NZWalksApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        private IRegionService _regionService;
        private IMapper _mapper;

        public RegionsController(IRegionService regionService, IMapper mapper)
        {
            _regionService = regionService;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<Region> GetSpecificRegion(int id)
        {
            Region region = _regionService.GetRegion(id);
            if (region == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(region);
            }
        }

        [HttpPost]
        public ActionResult AddRegion (AddRegionDTO addRagion)
        {
            Region region = _mapper.Map<Region>(addRagion);
            _regionService.AddRegion(region);
            return Created();
        }
    }
}
