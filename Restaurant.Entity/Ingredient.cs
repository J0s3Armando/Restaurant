using System;
using System.Collections.Generic;

namespace Restaurant.Entity;

public partial class Ingredient
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public decimal Price { get; set; }

    public DateTime InsertDate { get; set; }

    public DateTime LastUpDate { get; set; }

    public DateTime? RemoveDate { get; set; }

    public virtual ICollection<CategoryIngredient> CategoryIngredients { get; } = new List<CategoryIngredient>();
}
