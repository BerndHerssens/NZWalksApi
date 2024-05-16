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
        public async Task<ActionResult<WalkDTO>> GetSpecificWalkAsync(int id)
        {
            Walk walk = await _walkservice.GetWalkAsync(id);
            WalkDTO dto = _mapper.Map<WalkDTO>(walk);

            if (walk == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(dto);
            }
        }
        [HttpGet]
        [Route("GetAllWalks")]
        public async Task<ActionResult<WalkDTO>> GetAllWalksAsync()
        {
            IEnumerable<Walk> walks = await _walkservice.GetAllWalksAsync();
            IEnumerable<WalkDTO> walkDtos = _mapper.Map<IEnumerable<WalkDTO>>(walks);

            if (walks == null || walks.Count() == 0)
            {
                return NotFound();
            }
            else
            {
                return Ok(walkDtos);
            }
        }
        [HttpPost]
        public async Task<ActionResult> AddWalkAsync(AddWalkDTO addWalk)
        {
            Walk walk = _mapper.Map<Walk>(addWalk);
            await _walkservice.AddWalkAsync(walk);
            return Created();
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteWalkAsync(int id)
        {
            await _walkservice.DeleteWalkByIdAsync(id);
            return Created();
        }

        [HttpPut]
        public async Task<ActionResult> UpdateWalkAsync(int id, UpdateWalkDTO updateWalk)
        {
            Walk walk = _mapper.Map<Walk>(updateWalk);
            await _walkservice.UpdateWalkAsync(id, walk);
            return Created();
        }
    }
}
