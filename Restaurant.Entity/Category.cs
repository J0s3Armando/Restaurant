using System;
using System.Collections.Generic;

namespace Restaurant.Entity;

public partial class Category
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime InsertDate { get; set; }

    public DateTime LastUpdate { get; set; }

    public DateTime? RemoveDate { get; set; }

    public virtual ICollection<CategoryIngredient> CategoryIngredients { get; } = new List<CategoryIngredient>();

    public virtual ICollection<OrderProduct> OrderProducts { get; } = new List<OrderProduct>();

    public virtual ICollection<Product> Products { get; } = new List<Product>();
}
