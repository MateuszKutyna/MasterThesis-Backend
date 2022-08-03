using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MasterThesis_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        private static List<SuperHero> heroes = new List<SuperHero>
            {
                new SuperHero{
                    Id = 1,
                    Name = "Hulk",
                    FirstName = "Bruce",
                    LastName = "Banner",
                    Place="New York City"
                }
            };

        [HttpGet("allHeroes")]
        public async Task<ActionResult<List<SuperHero>>> Get()
        {
            
            return Ok(heroes);

        }

        [HttpPost("editHeroes")]
        public async Task<ActionResult<List<SuperHero>>> AddHero(SuperHero hero)
        {
            heroes.Add(hero);
            return Ok(heroes); 
        }

    }
}
