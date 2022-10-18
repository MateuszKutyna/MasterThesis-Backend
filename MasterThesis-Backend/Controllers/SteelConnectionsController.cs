using MasterThesis_Backend.Services;
using Microsoft.AspNetCore.Mvc;

namespace MasterThesis_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SteelConnectionsController : ControllerBase
    {
        private readonly ISteelConnectionsService steelConnectionsService;

        public SteelConnectionsController(ISteelConnectionsService steelConnectionsService)
        {
            this.steelConnectionsService = steelConnectionsService;
        }
        [HttpGet("GetSteelConnections")]
        public ActionResult<SteelConnections> GetSteelConnections()
        {
            return Ok(steelConnectionsService.GetSteelConnections());
        }
    }
}
