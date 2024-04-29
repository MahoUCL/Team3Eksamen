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

        [HttpGet]
        public async Task<ActionResult<List<Obstacle>>> GetAllObstacles()
        {
            var obstacles = await _context.Obstacles.ToListAsync();
            return Ok(obstacles);

        }
    }
}


