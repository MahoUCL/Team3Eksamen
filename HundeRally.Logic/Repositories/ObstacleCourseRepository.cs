using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HundeRally.Logic.interfaces;
using HundeRally.Logic.Data;
using HundeRally.Logic.Entity;

namespace HundeRally.Logic.Repositories
{
    public class ObstacleCourseRepository : IObstacleCourseRepository
    {
        private readonly RallyContext _context;
        private readonly IObstacleRepository _obstacleRepository;


        public ObstacleCourseRepository(RallyContext context)
        {
            _context = context;
        }

        public IEnumerable<ObstacleCourse> GetAllCourses()
        {
            throw new NotImplementedException();
        }

        public void AddCourse(ObstacleCourse course)
        {
            throw new NotImplementedException();
        }

        public void DeleteCourse(int id)
        {
            throw new NotImplementedException();
        }

        public ObstacleCourse GetCourseById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCourse(ObstacleCourse course)
        {
            throw new NotImplementedException();
        }

        public bool ValidateCourse(ObstacleCourse course)
        {
            throw new NotImplementedException();
        }
    }
}
