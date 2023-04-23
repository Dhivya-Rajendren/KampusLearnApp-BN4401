using System.Data.SqlClient;

namespace KampusLearnApp.Models
{
    public class SQLKampusLearnRepository : IKampusLearnRepository
    {


        //ADO .Net -Used for conencting the application with Database.

        //To use ADO .NET (Classes and methods)(In a Namespace - System.Data.SqlClient)-SQL Server 
        private string connectionString = "Server=Dhivya-pc\\SqlExpress;Database=KampusLearn_BN4401;integrated security=true";


        //Classes Related for ADO.Net
        SqlConnection con;
        SqlCommand com;
        SqlDataReader reader;

        public int AddNewCourse(Course course)
        {
            con = new SqlConnection(connectionString);
            con.Open();
            com = new SqlCommand("insert into tbl_Courses values('"+course.CourseName+"','"+course.Technology+"',"+course.Price+","+course.DurationInHours+")", con);
            return com.ExecuteNonQuery();
        }

        public List<Batch> GetBatches()
        {
            throw new NotImplementedException();
        }

        public Course GetCourseById(int courseId)
        {
            return GetCourses().Find(c => c.CourseId == courseId);
        }

        public List<Course> GetCourses()
        {
            List<Course> courses = new List<Course>();
            con = new SqlConnection(connectionString);
            con.Open();
        com = new SqlCommand("Select * from tbl_courses", con);
            reader = com.ExecuteReader();// For reading the data
            while(reader.Read())
            {
                Course course = new Course();
                course.CourseId = reader.GetInt32(0);
                course.CourseName = reader.GetString(1);
                course.Technology = reader.GetString(2);
                course.Price = reader.GetInt32(3);
                course.DurationInHours = reader.GetInt32(4);
                courses.Add(course);
             }
            reader.Close();
            con.Close();

            return courses;


        }

        public List<Student> GetStudents()
        {
            throw new NotImplementedException();
        }

        public List<Trainer> GetTrainers()
        {
            throw new NotImplementedException();
        }
    }
}
