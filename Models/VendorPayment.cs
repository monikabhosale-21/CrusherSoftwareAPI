using System;
using System.Collections.Generic;

namespace CrusherSoftwareAPI.Models;

public partial class VendorPayment
{
    public int Vend_Pay_Id { get; set; }

    public int Vend_Id { get; set; }

    public string? Vend_Name { get; set; }

    public int? Vend_Ac_Id { get; set; }

    public DateTime Vend_Pay_Date { get; set; }

    public decimal Pay_Amt { get; set; }

    public string? Chk_No { get; set; }

    public DateTime? Chk_Date { get; set; }

    public string? Pay_For { get; set; }

    public string? Pay_Desc { get; set; }

    public decimal? Vend_Due { get; set; }

    public decimal? Final_Due { get; set; }

    public string? Pay_Mode { get; set; }
}
