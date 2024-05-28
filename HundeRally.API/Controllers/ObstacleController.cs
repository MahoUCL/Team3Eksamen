using Microsoft.AspNetCore.Mvc;
using HundeRally.API.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using HundeRally.API.Areas.Identity.Data;

namespace HundeRally.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObstacleController : ControllerBase
    {
        private readonly APIDataContext _context;

        public ObstacleController(APIDataContext context)
        {
            _context = context;
        }

        // GET: api/Obstacle
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Obstacle>>> GetObstacles()
        {
            return await _context.Obstacles.ToListAsync();
        }

        // GET: api/Obstacle/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Obstacle>> GetObstacle(int id)
        {
            var obstacle = await _context.Obstacles.FindAsync(id);

            if (obstacle == null)
            {
                return NotFound();
            }

            return obstacle;
        }

        // PUT: api/Obstacle/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutObstacle(int id, Obstacle obstacle)
        {
            if (id != obstacle.Id)
            {
                return BadRequest();
            }

            _context.Entry(obstacle).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ObstacleExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }


        [HttpPost]
        public async Task<ActionResult<Obstacle>> PostObstacle(CreateObstacleDto createObstacleDto)
        {
            var obstacle = new Obstacle
            {
                // Map the properties from the DTO to the new Obstacle
                Name = createObstacleDto.Name,
                Description = createObstacleDto.Description

    };

            _context.Obstacles.Add(obstacle);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetObstacle", new { id = obstacle.Id }, obstacle);
        }

        // DELETE: api/Obstacle/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteObstacle(int id)
        {
            var obstacle = await _context.Obstacles.FindAsync(id);
            if (obstacle == null)
            {
                return NotFound();
            }

            _context.Obstacles.Remove(obstacle);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ObstacleExists(int id)
        {
            return _context.Obstacles.Any(e => e.Id == id);
        }
    }
}
