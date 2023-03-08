using System;
using System.Collections.Generic;

namespace Restaurant.Entity;

public partial class Via
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime InsertDate { get; set; }

    public virtual ICollection<Order> Orders { get; } = new List<Order>();
}
