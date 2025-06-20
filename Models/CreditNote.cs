using System;
using System.Collections.Generic;

namespace CrusherSoftwareAPI.Models;

public partial class CreditNote
{
    public int Credit_Note_Id { get; set; }

    public string AC_Type { get; set; } = null!;

    public int Note_No { get; set; }

    public DateTime Credit_Date { get; set; }

    public string? Type { get; set; }

    public int? Cust_Id { get; set; }

    public int? Vend_Id { get; set; }

    public decimal? Due_Amt { get; set; }

    public decimal? Credit_Amt { get; set; }

    public decimal? Tax_Rate { get; set; }

    public decimal? Tax_Amt { get; set; }

    public decimal? Final_Amt { get; set; }

    public decimal? Final_Due_Amt { get; set; }

    public string? Credit_Desc { get; set; }

    public string? Reason { get; set; }

    public string? Cust_Mobile { get; set; }

    public string? Vend_Mobile { get; set; }

    public string? Invoice_No { get; set; }

    public DateOnly? BM_Date { get; set; }

    public string? Prod_Name { get; set; }

    public string? HSN_No { get; set; }

    public decimal? Rate { get; set; }

    public int? BM_Id { get; set; }

    public int? PURM_Id { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
