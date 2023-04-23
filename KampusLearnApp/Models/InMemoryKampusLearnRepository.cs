namespace KampusLearnApp.Models
{
    public class InMemoryKampusLearnRepository : IKampusLearnRepository
    {
        static private List<Course> _courses;

        public int AddNewCourse(Course course)
        {
            throw new NotImplementedException();
        }

        public List<Batch> GetBatches()
        {
            throw new NotImplementedException();
        }

        public Course GetCourseById(int courseId)
        {
            return GetCourses().Find(c => c.CourseId == courseId);
        }

        //Retuning the List of courses
        public List<Course> GetCourses()
        {
          _courses = new List<Course>()
            {
                new Course(){CourseId=1,CourseName="ASP .NET Core MVC Developer",Technology="Full Stack Development",Price=12999,DurationInHours=20},
                new Course(){CourseId=2,CourseName="AWS Developer",Technology="Cloud Computing",Price=12999,DurationInHours=20},
                new Course(){CourseId=3,CourseName="Angular - Web Developer",Technology="FrontEnd",Price=10999,DurationInHours=20},
                new Course(){CourseId=4,CourseName="Essentials of SQL",Technology="Database",Price=9999,DurationInHours=20},

            };

            return _courses;
        }

        public List<Student> GetStudents()
        {
            throw new NotImplementedException();
        }

        public List<Trainer> GetTrainers()
        {
            List<Trainer> trainers = new List<Trainer>() { 
            
            new Trainer(){TrainerId=1,TrainerName="Dhivya",Skills=".Net Core, Azure DevOps, Angular",YearsOfExperience=11,Contact=9976408018,Email="dhivya@ck.com"},
            new Trainer(){TrainerId=2,TrainerName="Aabha",Skills=".Net Core, AWS, Angular",YearsOfExperience=13,Contact=9976408028,Email="Aabha@ck.com"},
            new Trainer(){TrainerId=3,TrainerName="Geetha",Skills=".Net Core, Azure DevOps, Angular,React",YearsOfExperience=15,Contact=9976408038,Email="Geeths@ck.com"},

            };

            return trainers;
        }
    }
}
