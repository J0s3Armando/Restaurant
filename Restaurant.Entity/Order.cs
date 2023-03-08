using System;
using System.Collections.Generic;

namespace Restaurant.Entity;

public partial class Order
{
    public int Id { get; set; }

    public decimal TotalAmount { get; set; }

    public int NumberProducts { get; set; }

    public int? IdmethodPayment { get; set; }

    public int? IdtableBranch { get; set; }

    public int? Idvia { get; set; }

    public int? Idstatus { get; set; }

    public int? Iduser { get; set; }

    public DateTime InsertDate { get; set; }

    public DateTime LastUpDate { get; set; }

    public DateTime? CancelDate { get; set; }

    public virtual MethodPayment? IdmethodPaymentNavigation { get; set; }

    public virtual Status? IdstatusNavigation { get; set; }

    public virtual TableBranch? IdtableBranchNavigation { get; set; }

    public virtual User? IduserNavigation { get; set; }

    public virtual Via? IdviaNavigation { get; set; }

    public virtual ICollection<OrderProduct> OrderProducts { get; } = new List<OrderProduct>();
}
