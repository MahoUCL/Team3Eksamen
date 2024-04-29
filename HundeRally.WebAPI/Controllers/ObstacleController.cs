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

        //CRUD READ
        //Denne kommando henter en liste med alle obstacles fra databasen
        [HttpGet]
        public async Task<ActionResult<List<Obstacle>>> GetAllObstacles()
        {
            var obstacles = await _context.Obstacles.ToListAsync();
            return Ok(obstacles);

        }

        //CRUD READ BY ID
        //Denne kommando henter en obstacle fra databasen baseret på Id
        [HttpGet]
        // [Route attributten nedenfor tillader klienten at få en bestemt obstacle baseret på Id]
        [Route("{Id}")]
        public async Task<ActionResult<Obstacle>> GetObstacle(int Id)
        {
            var obstacle = await _context.Obstacles.FindAsync(Id);
            if (obstacle is null)
                return NotFound("Obstacle not found");
            return Ok(obstacle);

        }


        //CRUD CREATE
        [HttpPost]
        //Her bør vi lave et DTO objekt, som vi kan bruge til at sende data til databasen. Dette gør vi for at begrænse data , som vi sender til databasen.(Altså udelader Id eksempelvis)
        public async Task<ActionResult<List<Obstacle>>> AddObstacle(Obstacle obstacle)
        {
            _context.Obstacles.Add(obstacle);
            await _context.SaveChangesAsync();

            return Ok(obstacle);

        }

        //CRUD UPDATE
        [HttpPut]
        public async Task<ActionResult<List<Obstacle>>> UpdateObstacle(Obstacle updatedObstacle)
        {
            var dbObstacle = await _context.Obstacles.FindAsync(updatedObstacle.Id);
            if (dbObstacle is null)
                return NotFound("Obstacle not found");

            dbObstacle.Number = updatedObstacle.Number;
            dbObstacle.Name = updatedObstacle.Name;
            dbObstacle.Description = updatedObstacle.Description;

            await _context.SaveChangesAsync();

            return Ok(updatedObstacle);

        }

        //CRUD DELETE
        [HttpDelete]
        public async Task<ActionResult<List<Obstacle>>> DeleteObstacle(int Id)
        {
            var dbObstacle = await _context.Obstacles.FindAsync(Id);
            if (dbObstacle is null)
                return NotFound("Obstacle not found");

            _context.Obstacles.Remove(dbObstacle);
            await _context.SaveChangesAsync();

            return Ok(await _context.Obstacles.ToListAsync());

        }
    }
}


