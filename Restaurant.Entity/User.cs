using System;
using System.Collections.Generic;

namespace Restaurant.Entity;

public partial class User
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime BirthDate { get; set; }

    public string Address { get; set; } = null!;

    public string Telephone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int? Idrol { get; set; }

    public string PostalCode { get; set; } = null!;

    public int? Idcountry { get; set; }

    public int? Idstate { get; set; }

    public string? Photo { get; set; }

    public string? Urlphoto { get; set; }

    public bool IsBlocked { get; set; }

    public DateTime InsertDate { get; set; }

    public DateTime LastUpdate { get; set; }

    public string Password { get; set; } = null!;

    public virtual Country? IdcountryNavigation { get; set; }

    public virtual Rol? IdrolNavigation { get; set; }

    public virtual State? IdstateNavigation { get; set; }

    public virtual ICollection<Order> Orders { get; } = new List<Order>();
}
