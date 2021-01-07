using System.Collections.Generic;

namespace Office.Models
{
  public class Patient
  {
    public Patient()
    {
      // this.Doctors = new HashSet<DoctorPatient>();
      this.Specialties = new HashSet<DoctorPatientSpecialty>();
      this.Doctors = new HashSet<DoctorPatientSpecialty>();
    }

    public int PatientId { get; set; }
    public string PatientName { get; set; }
    public string DOB { get; set; }

    public ICollection<DoctorPatientSpecialty> Doctors { get; }
    public ICollection<DoctorPatientSpecialty> Specialties { get; }
  }
}