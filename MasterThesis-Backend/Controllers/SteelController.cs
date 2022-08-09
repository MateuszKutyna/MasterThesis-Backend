using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MasterThesis_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SteelController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public SteelController(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }

        [HttpGet("getSteels")]
        public async Task<ActionResult<List<Steel>>> GetSteels()
        {
            return Ok(await _dataContext.Steels.ToListAsync());
        }

        [HttpGet("getSteelById")]
        public async Task<ActionResult<Steel>> GetSteelById(int id)
        {
            var steel = await _dataContext.Steels.FindAsync(id);
            if(steel == null)
            {
                return BadRequest("Steal not found");
            }
            return Ok(steel);
        }

        [HttpPost("addSteel")]
        public async Task<ActionResult<List<Steel>>> AddSteel(Steel steal)
        {
           
            _dataContext.Steels.Add(steal);
            await _dataContext.SaveChangesAsync();

            return Ok(await _dataContext.Steels.ToListAsync());
        }

        
    }
}
