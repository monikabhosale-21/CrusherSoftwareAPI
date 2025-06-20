using System;
using System.Collections.Generic;

namespace CrusherSoftwareAPI.Models;

public partial class PurchasePayment
{
    public int PaymentId { get; set; }

    public int PurmId { get; set; }

    public string? PayMode { get; set; }

    public string? ChkNo { get; set; }

    public DateTime? ChkDate { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual PurchaseMaster Purm { get; set; } = null!;
}
