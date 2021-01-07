using System.Collections.Generic;

namespace Office.Models
{
  public class Specialty
  {
    public Specialty()
    {
      // this.Doctors = new HashSet<DoctorPatient>();
      this.Doctors = new HashSet<DoctorPatientSpecialty>();
      this.Patients = new HashSet<DoctorPatientSpecialty>();
    }

    public int SpecialtyId { get; set; }
    public string SpecialtyName { get; set; }

    public ICollection<DoctorPatientSpecialty> Doctors { get; }
    public ICollection<DoctorPatientSpecialty> Patients { get; }
  }
}