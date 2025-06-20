using System;
using System.Collections.Generic;

namespace CrusherSoftwareAPI.Models;

public partial class SaleDetail
{
    public int BdId { get; set; }

    public int BmId { get; set; }

    public int ProdId { get; set; }

    public string? ProdName { get; set; }

    public decimal? Rate { get; set; }

    public decimal? Qnty { get; set; }

    public string? Unit { get; set; }

    public decimal? Amt { get; set; }

    public decimal? TotalWt { get; set; }

    public decimal? EmptyWt { get; set; }

    public decimal? Disc { get; set; }

    public string? DiscMode { get; set; }

    public decimal? DiscAmt { get; set; }

    public decimal? Rent { get; set; }

    public decimal? Pump { get; set; }

    public decimal? Transport { get; set; }

    public int? IndexNo { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual SaleMaster Bm { get; set; } = null!;
}
