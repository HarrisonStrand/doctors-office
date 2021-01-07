using Microsoft.EntityFrameworkCore;

namespace Office.Models
{
  public class OfficeContext : DbContext
  {
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Specialty> Specialties { get; set; }
    public DbSet<DoctorPatientSpecialty> DoctorPatientSpecialties { get; set; }
    // public DbSet<DoctorPatient> DoctorPatient { get; set; }

    public OfficeContext(DbContextOptions options) : base(options) { }
  }
}