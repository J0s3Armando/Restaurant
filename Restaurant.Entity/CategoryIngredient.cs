using System;
using System.Collections.Generic;

namespace Restaurant.Entity;

public partial class CategoryIngredient
{
    public int Id { get; set; }

    public int? Idcategory { get; set; }

    public int? Idingredient { get; set; }

    public DateTime InsertDate { get; set; }

    public DateTime LastUpDate { get; set; }

    public DateTime? RemoveDate { get; set; }

    public virtual Category? IdcategoryNavigation { get; set; }

    public virtual Ingredient? IdingredientNavigation { get; set; }
}
