using System;
using System.Collections.Generic;

namespace CrusherSoftwareAPI.Models;

public partial class Payment
{
    public int PaymentId { get; set; }

    public string? PaymentMode { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
