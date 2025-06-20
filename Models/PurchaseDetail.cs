using System;
using System.Collections.Generic;

namespace CrusherSoftwareAPI.Models;

public partial class PurchaseDetail
{
    public int PurdId { get; set; }

    public int PurmId { get; set; }

    public int ProdId { get; set; }

    public string? ProdName { get; set; }

    public decimal? Rate { get; set; }

    public decimal? Qnty { get; set; }

    public string? Unit { get; set; }

    public decimal? Amt { get; set; }

    public decimal? DiscAmt { get; set; }

    public decimal? TotAmt { get; set; }

    public decimal? Morang { get; set; }

    public decimal? GrossWeight { get; set; }

    public decimal? EmptyWeight { get; set; }

    public int? IndexNo { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual PurchaseMaster Purm { get; set; } = null!;
}
