using System;
using System.Collections.Generic;

namespace Restaurant.Entity;

public partial class ProductImage
{
    public int Id { get; set; }

    public int? Idproduct { get; set; }

    public int? Idimage { get; set; }

    public DateTime InsertDate { get; set; }

    public DateTime LastUpDate { get; set; }

    public DateTime? RemoveDate { get; set; }

    public virtual Image? IdimageNavigation { get; set; }

    public virtual Product? IdproductNavigation { get; set; }
}
