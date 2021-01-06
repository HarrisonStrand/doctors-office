using Microsoft.EntityFrameworkCore;

namespace Office.Models
{
  public class OfficeContext : DbContext
  {
    public virtual DbSet<Doctor> Doctors { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<DoctorPatient> DoctorPatient { get; set; }

    public OfficeContext(DbContextOptions options) : base(options) { }
  }
}