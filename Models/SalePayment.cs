using System;
using System.Collections.Generic;

namespace CrusherSoftwareAPI.Models;

public partial class SalePayment
{
    public int PaymentId { get; set; }

    public int BmId { get; set; }

    public string? PayMode { get; set; }

    public string? ChkNo { get; set; }

    public DateTime? ChkDate { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual SaleMaster Bm { get; set; } = null!;
}
