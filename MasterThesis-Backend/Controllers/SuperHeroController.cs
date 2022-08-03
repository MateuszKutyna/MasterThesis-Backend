using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MasterThesis_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {

        private readonly DataContext dataContext;

        public SuperHeroController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }



        [HttpGet("allHeroes")]
        public async Task<ActionResult<List<SuperHero>>> Get()
        {
            
            return Ok(await dataContext.SuperHeroes.ToListAsync());

        }

        [HttpPost("addHero")]
        public async Task<ActionResult<List<SuperHero>>> AddHero(SuperHero hero)
        {
            dataContext.SuperHeroes.Add(hero);
            await dataContext.SaveChangesAsync();

            return Ok(await dataContext.SuperHeroes.ToListAsync()); 
        }

        [HttpGet("getHero")]
        public async Task<ActionResult<SuperHero>> GetHero(int id)
        {
            var hero = await dataContext.SuperHeroes.FindAsync(id);
            if (hero == null)
            {
                return BadRequest("No hero found");
            }
            return Ok(hero);
        }

        [HttpPut("editHero")]
        public async Task<ActionResult<List<SuperHero>>> EditHero(SuperHero hero)
        {
            var foundHero = await dataContext.SuperHeroes.FindAsync(hero.Id);
            if (foundHero == null) {
                return BadRequest("No hero found");
            }

            foundHero.Name = hero.Name;
            foundHero.FirstName = hero.FirstName;
            foundHero.LastName = hero.LastName; 
            foundHero.Place = hero.Place;

            await dataContext.SaveChangesAsync();
            return Ok(await dataContext.SuperHeroes.ToListAsync());

        }

        [HttpDelete("removeHero")]
        public async Task<ActionResult<List<SuperHero>>> removeHero(int id)
        {
            var foundHero = await dataContext.SuperHeroes.FindAsync(id);
            if (foundHero == null)
            {
                return BadRequest("Invalid Hero ID");
            }

            dataContext.SuperHeroes.Remove(foundHero);
            await dataContext.SaveChangesAsync();
           

            return Ok(await dataContext.SuperHeroes.ToListAsync());

        }

    }
}
