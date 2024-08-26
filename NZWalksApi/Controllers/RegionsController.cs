using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NZWalksApi.Business.Models;
using NZWalksApi.Business.Services;
using NZWalksApi.DTO;

namespace NZWalksApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class RegionsController : ControllerBase
    {
        private IRegionService _regionService;
        private IMapper _mapper;

        public RegionsController(IRegionService regionService, IMapper mapper)
        {
            _regionService = regionService;
            _mapper = mapper;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<RegionDTO>> GetSpecificRegionAsync(int id)
        {
            Region region = await _regionService.GetRegionAsync(id);
            RegionDTO regionDTO = _mapper.Map<RegionDTO>(region);

            if (region == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(regionDTO);
            }
        }

        [HttpGet]
        [Route("GetAllRegions")]
        public async Task<ActionResult<IEnumerable<RegionDTO>>> GetAllRegionsAsync(bool incloudWalks)
        {
            IEnumerable<Region> regions;
            IEnumerable<RegionDTO> regionsDTO;

            if (incloudWalks)
            {
                regions = await _regionService.GetAllRegionsWithWalksAsync();
            }
            else
            {
                regions = await _regionService.GetAllRegionsAsync();
            }
            regionsDTO = _mapper.Map<IEnumerable<RegionDTO>>(regions);

            if (regions == null || regions.Count() == 0)
            {
                return NotFound();
            }
            else
            {
                return Ok(regionsDTO);
            }
        }

        [HttpPost]
        public async Task<ActionResult> AddRegionAsync(AddRegionDTO addRegion)
        {
            if (ModelState.IsValid)
            {
                Region region = _mapper.Map<Region>(addRegion);
                await _regionService.AddRegionAsync(region);
                return Created();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete]
        public async Task<ActionResult> DeleteRegionAsync(int id)
        {
            await _regionService.DeleteRegionByIdAsync(id);
            return Created();
        }

        [HttpPut]
        public async Task<ActionResult> UpdateRegionAsync(int id, UpdateRegionDTO updateRegion)
        {
            if (ModelState.IsValid)
            {
                Region region = _mapper.Map<Region>(updateRegion);
                await _regionService.UpdateRegionAsync(id, region);
                return Created();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}