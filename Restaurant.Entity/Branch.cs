using System;
using System.Collections.Generic;

namespace Restaurant.Entity;

public partial class Branch
{
    public int Id { get; set; }

    public int? Idcompany { get; set; }

    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string PostalCode { get; set; } = null!;

    public string Telephone { get; set; } = null!;

    public int? Idcountry { get; set; }

    public int? Idstate { get; set; }

    public DateTime InsertDate { get; set; }

    public DateTime LastUpdate { get; set; }

    public DateTime? RemoveDate { get; set; }

    public virtual Company? IdcompanyNavigation { get; set; }

    public virtual Country? IdcountryNavigation { get; set; }

    public virtual State? IdstateNavigation { get; set; }

    public virtual ICollection<TableBranch> TableBranches { get; } = new List<TableBranch>();
}
