namespace KampusLearnApp.Models
{
    public interface IKampusLearnRepository
    {

        // What are the Functionalities.

        List<Course> GetCourses();

        Course GetCourseById(int courseId);
        List<Student> GetStudents();
        List<Batch> GetBatches();
        List<Trainer> GetTrainers();

        int AddNewCourse(Course course);


    }
}
