using System;
using System.Collections.Generic;

namespace APIDemoProject.Models;

public partial class State
{
    public int StateId { get; set; }

    public int CountryId { get; set; }

    public string StateName { get; set; } = null!;

    public string? StateCode { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<City> Cities { get; set; } = new List<City>();

    public virtual Country Country { get; set; } = null!;
}
