using System;
using System.Collections.Generic;

namespace Restaurant.Entity;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public decimal? HightPrice { get; set; }

    public decimal SalePrice { get; set; }

    public decimal? BasePrice { get; set; }

    public int? Idcategory { get; set; }

    public bool IsSuspend { get; set; }

    public DateTime InsertDate { get; set; }

    public DateTime LastUpDate { get; set; }

    public DateTime? RemoveDate { get; set; }

    public virtual Category? IdcategoryNavigation { get; set; }

    public virtual ICollection<Image> Images { get; } = new List<Image>();

    public virtual ICollection<OrderProduct> OrderProducts { get; } = new List<OrderProduct>();
}
