using HundeRally.WebAPI.Data;
using HundeRally.WebAPI.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace HundeRally.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObstacleController : ControllerBase
    {
        private readonly DataContext _context;

        public ObstacleController(DataContext context)
        {
            _context = context;
        }

        //Denne kommando henter en liste med alle obstacles fra databasen
        [HttpGet]
        public async Task<ActionResult<List<Obstacle>>> GetAllObstacles()
        {
            var obstacles = await _context.Obstacles.ToListAsync();
            return Ok(obstacles);

        }

        //Denne kommando henter en obstacle fra databasen baseret på Id
        [HttpGet ]
        // [Route attributten nedenfor tillader klienten at få en bestemt obstacle baseret på Id]
        [Route ("{Id}")]
        public async Task<ActionResult<List<Obstacle>>> GetObstacle(int Id)
        {
            var obstacle = await _context.Obstacles.FindAsync(Id);
            if (obstacle is null)
                return NotFound("Obstacle not found");
            return Ok(obstacle);

        }
    }
}


