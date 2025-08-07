using System;
using System.Collections.Generic;

namespace HospitalManagementProject.Models;

public partial class Patient
{
    public int PatientId { get; set; }

    public string PatientName { get; set; } = null!;

    public string Contact { get; set; } = null!;

    public int Age { get; set; }

    public bool EarlierOperation { get; set; }

    public string BloodGroup { get; set; } = null!;
}
