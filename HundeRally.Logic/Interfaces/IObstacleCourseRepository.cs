using HundeRally.Logic.Entity;

namespace HundeRally.Logic;
public partial interface interfaces
    {
    public interface IObstacleCourseRepository
    {
        IEnumerable<ObstacleCourse> GetAllCourses();
        ObstacleCourse GetCourseById(int id);
        void AddCourse(ObstacleCourse course);
        void UpdateCourse(ObstacleCourse course);
        void DeleteCourse(int id);
        bool ValidateCourse(ObstacleCourse course); 
    }
}
