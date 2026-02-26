using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DEMOAPI.Models;

public partial class Order
{
    public int Id { get; set; }

    public string OrderNumber { get; set; } = null!;

    public decimal TotalAmount { get; set; }

    public int UserId { get; set; }

    public DateTime? OrderDate { get; set; }

    [JsonIgnore]
    public virtual User? User { get; set; }
}
