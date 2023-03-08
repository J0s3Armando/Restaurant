using System;
using System.Collections.Generic;

namespace Restaurant.Entity;

public partial class Company
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Logo { get; set; }

    public string? Urllogo { get; set; }

    public DateTime InsertDate { get; set; }

    public DateTime LastUpDate { get; set; }

    public DateTime? RemoveDate { get; set; }

    public virtual ICollection<Branch> Branches { get; } = new List<Branch>();
}
