using System;
using System.Collections.Generic;

namespace Restaurant.Entity;

public partial class MethodPayment
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime InsertDate { get; set; }

    public DateTime LastUpDate { get; set; }

    public DateTime? RemoveDate { get; set; }

    public virtual ICollection<Order> Orders { get; } = new List<Order>();
}
