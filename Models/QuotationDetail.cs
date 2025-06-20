using System;
using System.Collections.Generic;

namespace CrusherSoftwareAPI.Models;

public partial class QuotationDetail
{
    public int Quod_Id { get; set; }

    public int Quom_Id { get; set; }

    public int Prod_Id { get; set; }

    public string? Prod_Name { get; set; }

    public decimal? Rate { get; set; }

    public decimal? Qnty { get; set; }

    public string? Unit { get; set; }

    public decimal? Amt { get; set; }

    public decimal? Tax_Rate { get; set; }

    public decimal? Tax_Amt { get; set; }

    public decimal? Taxble_Amt { get; set; }

    public decimal? Tot_Amt { get; set; }

    public decimal? Enq_Amt { get; set; }

    public decimal? Enq_Taxble_Amt { get; set; }

    public decimal? Enq_Tax_Amt { get; set; }

    public decimal? Enq_Taxable_Amt { get; set; }

    public decimal? Enq_Tot_Amt { get; set; }

    public int? Index_No { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual QuotationMaster Quom { get; set; } = null!;
}
