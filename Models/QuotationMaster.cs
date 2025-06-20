using System;
using System.Collections.Generic;

namespace CrusherSoftwareAPI.Models;

public partial class QuotationMaster
{
    public int Quom_Id { get; set; }

    public DateTime Quo_Date { get; set; }

    public string? Quo_No { get; set; }

    public string? Ref_No { get; set; }

    public string? Ref_Name { get; set; }

    public int Cust_Id { get; set; }

    public string? Cust_Name { get; set; }

    public string? Cust_Mobile { get; set; }

    public string? Cust_City { get; set; }

    public string? Vehi_No { get; set; }

    public string? Trip_Type { get; set; }

    public decimal? Diesel { get; set; }

    public decimal? Rent { get; set; }

    public string? Location { get; set; }

    public decimal? Final_Amt { get; set; }

    public decimal? Rec_Amt { get; set; }

    public decimal? Due_Amt { get; set; }

    public string? Disc_Qua { get; set; }

    public bool? Term_Flag { get; set; }

    public decimal? Pre_Due { get; set; }

    public decimal? Final_Due { get; set; }

    public decimal? Taxable_Amt { get; set; }

    public decimal? Disc_Amt { get; set; }

    public decimal? Bill_Amt { get; set; }

    public decimal? Tax_Amt { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<QuotationDetail> QuotationDetails { get; set; } = new List<QuotationDetail>();

    public virtual ICollection<QuotationTerm> QuotationTerms { get; set; } = new List<QuotationTerm>();
}
