using System;
using System.Collections.Generic;

namespace APIDemoProject.Models;

public partial class City
{
    public int CityId { get; set; }

    public int StateId { get; set; }

    public int CountryId { get; set; }

    public string CityName { get; set; } = null!;

    public string? CityCode { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual Country Country { get; set; } = null!;

    public virtual State State { get; set; } = null!;
}
