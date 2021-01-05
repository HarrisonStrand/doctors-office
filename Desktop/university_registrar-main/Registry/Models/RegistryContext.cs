using Microsoft.EntityFrameworkCore;

namespace Registry.Models
{
  public class RegistryContext : DbContext
  {
    public virtual DbSet<Course> Courses { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<CourseStudent> CourseStudent { get; set; }

    public RegistryContext(DbContextOptions options) : base(options) { }
  }
}