using System;
using System.Collections.Generic;

namespace Restaurant.Entity;

public partial class State
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Abbreviation { get; set; } = null!;

    public int? Idcountry { get; set; }

    public DateTime InsertDate { get; set; }

    public DateTime LastUpdate { get; set; }

    public DateTime? RemoveDate { get; set; }

    public virtual ICollection<Branch> Branches { get; } = new List<Branch>();

    public virtual Country? IdcountryNavigation { get; set; }

    public virtual ICollection<User> Users { get; } = new List<User>();
}
