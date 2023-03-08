using System;
using System.Collections.Generic;

namespace Restaurant.Entity;

public partial class OrderProduct
{
    public int Id { get; set; }

    public int? Idorder { get; set; }

    public string Name { get; set; } = null!;

    public decimal Price { get; set; }

    public int Quantity { get; set; }

    public decimal TotalAmount { get; set; }

    public int? Idcategory { get; set; }

    public int? Idproduct { get; set; }

    public DateTime InsertDate { get; set; }

    public DateTime LastUpDate { get; set; }

    public DateTime? CancelDate { get; set; }

    public virtual Category? IdcategoryNavigation { get; set; }

    public virtual Order? IdorderNavigation { get; set; }

    public virtual Product? IdproductNavigation { get; set; }
}
