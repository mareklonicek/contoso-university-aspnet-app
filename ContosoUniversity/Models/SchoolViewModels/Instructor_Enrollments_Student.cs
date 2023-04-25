using Microsoft.AspNetCore.Mvc.Rendering;

namespace ContosoUniversity.Models.SchoolViewModels
{
    public class Instructor_Enrollments_Student
    {
        public IEnumerable<Student> Students { get; set; }
        public IEnumerable<Instructor> Instructors { get; set; }
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<Department> Departments { get; set; }
        public Course Course { get; set; }
        public List<string>? SelectedCourses { get; set; }



    }
}
