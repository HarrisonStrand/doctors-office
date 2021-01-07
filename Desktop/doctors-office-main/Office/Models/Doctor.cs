using System.Collections.Generic;
using System;

namespace Office.Models
{
  public class Doctor
  {
    public Doctor()
    {
      // this.Patients = new HashSet<DoctorPatient>();
      this.Patients = new HashSet<DoctorPatientSpecialty>();
      this.Specialties = new HashSet<DoctorPatientSpecialty>();
    }
    public int DoctorId { get; set; }
    public string DoctorName { get; set; }
    public string DoctorSpecialty { get; set; }

    // public virtual ICollection<DoctorPatient> Patients { get; set; }
    public ICollection<DoctorPatientSpecialty> Patients { get; set; }
    public ICollection<DoctorPatientSpecialty> Specialties { get; set; }
  }
}