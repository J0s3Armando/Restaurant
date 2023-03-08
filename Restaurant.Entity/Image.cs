using System;
using System.Collections.Generic;

namespace Restaurant.Entity;

public partial class Image
{
    public int Id { get; set; }

    public int? Idproduct { get; set; }

    public string Name { get; set; } = null!;

    public string Url { get; set; } = null!;

    public DateTime InsertDate { get; set; }

    public DateTime LastUpdate { get; set; }

    public DateTime? RemoveDate { get; set; }

    public virtual Product? IdproductNavigation { get; set; }
}
