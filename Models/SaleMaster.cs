using System;
using System.Collections.Generic;

namespace CrusherSoftwareAPI.Models;

public partial class SaleMaster
{
    public int BmId { get; set; }

    public string? InvoiceNo { get; set; }

    public string? RefNo { get; set; }

    public string? RefName { get; set; }

    public int CustId { get; set; }

    public string? CustName { get; set; }

    public string? CustMobile { get; set; }

    public string? VehiNo { get; set; }

    public decimal? Diesel { get; set; }

    public decimal? Rent { get; set; }

    public string? Location { get; set; }

    public decimal? DiscAmt { get; set; }

    public string? DriverNm { get; set; }

    public string? DriverMo { get; set; }

    public string? SaleMode { get; set; }

    public decimal? FinalAmt { get; set; }

    public decimal? RecAmt { get; set; }

    public decimal? DueAmt { get; set; }

    public decimal? BillAmt { get; set; }

    public decimal? WaitCharge { get; set; }

    public decimal? PurCharge { get; set; }

    public decimal? TaxCharge { get; set; }

    public decimal? TotPump { get; set; }

    public string? RoyInv { get; set; }

    public string? RoyaltyNo { get; set; }

    public decimal? PumpAmt { get; set; }

    public decimal? LabourAmt { get; set; }

    public string? DiscBy { get; set; }

    public DateTime? BmDate { get; set; }

    public decimal? PreDue { get; set; }

    public decimal? FinalDue { get; set; }

    public decimal? FinalAmt1 { get; set; }

    public decimal? FinalDue1 { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<SaleDetail> SaleDetails { get; set; } = new List<SaleDetail>();

    public virtual ICollection<SalePayment> SalePayments { get; set; } = new List<SalePayment>();
}
