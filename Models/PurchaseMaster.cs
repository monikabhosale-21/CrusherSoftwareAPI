using System;
using System.Collections.Generic;

namespace CrusherSoftwareAPI.Models;

public partial class PurchaseMaster
{
    public int PurmId { get; set; }

    public DateTime? PurmDate { get; set; }

    public string? PurmTime { get; set; }

    public string? PurFrom { get; set; }

    public string? RefNo { get; set; }

    public int? VendId { get; set; }

    public string? VendMobile { get; set; }

    public decimal? Diesel { get; set; }

    public decimal? Rent { get; set; }

    public string? Location { get; set; }

    public string? Remark { get; set; }

    public decimal? FinalAmt { get; set; }

    public decimal? RecAmt { get; set; }

    public decimal? DueAmt { get; set; }

    public int? EmpId { get; set; }

    public decimal? EmpRent { get; set; }

    public string? Type { get; set; }

    public decimal? TaxableAmt { get; set; }

    public decimal? DiscAmt { get; set; }

    public string? BillType { get; set; }

    public string? RoyInv { get; set; }

    public string? RoyaltyNo { get; set; }

    public decimal? PreDue { get; set; }

    public decimal? FinalDue { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<PurchaseDetail> PurchaseDetails { get; set; } = new List<PurchaseDetail>();

    public virtual ICollection<PurchasePayment> PurchasePayments { get; set; } = new List<PurchasePayment>();

    public virtual ICollection<PurchaseVehicle> PurchaseVehicles { get; set; } = new List<PurchaseVehicle>();
}
