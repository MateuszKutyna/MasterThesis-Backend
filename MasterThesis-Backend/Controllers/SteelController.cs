using MasterThesis_Backend.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc; //ControllerBase

namespace MasterThesis_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SteelController : ControllerBase
    {
        private readonly ISteelService _steelService;

        public SteelController(ISteelService steelService)
        {
            _steelService = steelService;
        }
        
        [HttpGet("GetAllSteels")]
        public async Task<ActionResult<List<Steel>>> GetAllSteels()
        {
            return Ok(await _steelService.GetAllSteels());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Steel>> GetSteelById(int id)
        {
            var steel = await _steelService.GetSteelById(id);
            if(steel == null)
            {
                return BadRequest("Steal not found");
            }
            return Ok(steel);
        }

        [HttpPost("AddSteel")]
        public async Task<ActionResult<List<Steel>>> AddSteel(Steel steel)
        {
            return Ok(await _steelService.AddSteel(steel));
        }

        
    }
}
