using System;
using System.Collections.Generic;

namespace Restaurant.Entity;

public partial class Country
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Abbreviation { get; set; } = null!;

    public DateTime InsertDate { get; set; }

    public DateTime LastUpdate { get; set; }

    public DateTime? RemoveDate { get; set; }

    public virtual ICollection<Branch> Branches { get; } = new List<Branch>();

    public virtual ICollection<State> States { get; } = new List<State>();

    public virtual ICollection<User> Users { get; } = new List<User>();
}
