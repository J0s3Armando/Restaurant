using System;
using System.Collections.Generic;

namespace Restaurant.Entity;

public partial class TableBranch
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int? Idbranch { get; set; }

    public DateTime InsertDate { get; set; }

    public DateTime LastUpdate { get; set; }

    public DateTime? RemoveDate { get; set; }

    public virtual Branch? IdbranchNavigation { get; set; }

    public virtual ICollection<Order> Orders { get; } = new List<Order>();
}
