using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string? LastName { get; set; }
        public string? FirstMidName { get; set; }
        [Display(Name = "Full Name")]
        public string FullName => LastName + ", " + FirstMidName;
        [DataType(DataType.Date)]
        public DateTime? EnrollmentDate { get; set; }

        public ICollection<Enrollment>? Enrollments { get; set; }
    }
}
