using System;
using System.Collections.Generic;

namespace Restaurant.Entity;

public partial class Setting
{
    public int Id { get; set; }

    public string Resource { get; set; } = null!;

    public string Property { get; set; } = null!;

    public string? Value { get; set; }

    public DateTime InsertDate { get; set; }
}
