using KampusLearnApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace KampusLearnApp.Controllers
{
    public class CourseController : Controller
    {
        public IKampusLearnRepository repo;
        public CourseController()
        {
            //  repo = new InMemoryKampusLearnRepository();

            repo = new SQLKampusLearnRepository();
        }
        //Default Action method
        public IActionResult Index()
        {
            List<Course> courses = repo.GetCourses();

            ViewBag.Courses = courses;
            return View();
        }

        public IActionResult GetCourse(int courseId)
        {
            ViewBag.Course = repo.GetCourseById(courseId);
            return View();
        }

        [HttpGet]
        public IActionResult AddNewCourse()
        {
            return View();
        }

        [HttpPost] // Is used for posting the data to the server
        public IActionResult AddNewCourse(Course course)
        {
            repo.AddNewCourse(course);
            return RedirectToAction("Index");
        }
    }
}
