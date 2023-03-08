using System;
using System.Collections.Generic;

namespace Restaurant.Entity;

public partial class Status
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime InsertDate { get; set; }

    public virtual ICollection<Order> Orders { get; } = new List<Order>();
}
