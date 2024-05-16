using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using NZWalksApi.Business.Models;
using NZWalksApi.Business.Services;
using NZWalksApi.DTO;

namespace NZWalksApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
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
        [AllowAnonymous]
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
        [AllowAnonymous]
        [Route("GetAllWalks")]
        public async Task<ActionResult<WalkDTO>> GetAllWalksAsync(int enterLength, int page = 1, int items = 20)
        {
            IEnumerable<Walk> walks = await _walkservice.GetAllWalksAsync(page, items, enterLength);
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
            try
            {
                if (ModelState.IsValid)
                {
                    Walk walk = _mapper.Map<Walk>(addWalk);
                    await _walkservice.AddWalkAsync(walk);
                    return Created();
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }

            catch (DbUpdateException ex)
            {
                return BadRequest("Region must exist!");
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }

        }


        [HttpDelete]
        [Authorize(Roles = "admin")]
        public async Task<ActionResult> DeleteWalkAsync(int id)
        {
            await _walkservice.DeleteWalkByIdAsync(id);
            return Created();
        }

        [HttpPut]
        public async Task<ActionResult> UpdateWalkAsync(int id, UpdateWalkDTO updateWalk)
        {
            if (ModelState.IsValid)
            {
                Walk walk = _mapper.Map<Walk>(updateWalk);
                await _walkservice.UpdateWalkAsync(id, walk);
                return Created();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}
