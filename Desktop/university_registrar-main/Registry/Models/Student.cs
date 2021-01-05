using System.Collections.Generic;

namespace Registry.Models
{
  public class Student
  {
    public Student()
    {
      this.Courses = new HashSet<CourseStudent>();
    }

    public int StudentId { get; set; }
    public string StudentName { get; set; }
    public string DOE { get; set; }

    public ICollection<CourseStudent> Courses { get; }

  }
}