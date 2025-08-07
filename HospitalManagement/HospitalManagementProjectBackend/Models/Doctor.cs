using System;
using System.Collections.Generic;

namespace HospitalManagementProject.Models;

public partial class Doctor
{
    public int DoctorId { get; set; }

    public string DoctorName { get; set; } = null!;

    public string Degree { get; set; } = null!;

    public int Experience { get; set; }

    public string? Specification { get; set; }

    public int Age { get; set; }

    public DateTime Dob { get; set; }
}
