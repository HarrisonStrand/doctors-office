using System.Collections.Generic;
using System;

namespace Office.Models
{
  public class Doctor
  {
    public Doctor()
    {
      this.Patients = new HashSet<DoctorPatient>();
    }
    public int DoctorId { get; set; }
    public string DoctorName { get; set; }
    public string DoctorSpecialty { get; set; }

    public virtual ICollection<DoctorPatient> Patients { get; set; }
  }
}