using System;
using System.Collections.Generic;

namespace CrusherSoftwareAPI.Models;

public partial class CustomerPayment
{
    public int Cust_Pay_Id { get; set; }

    public int Cust_Id { get; set; }

    public string? Cust_Name { get; set; }

    public int? Cust_Ac_Id { get; set; }

    public DateTime Cust_Pay_Date { get; set; }

    public decimal Pay_Amt { get; set; }

    public decimal? Discount { get; set; }

    public string? Chk_No { get; set; }

    public DateTime? Chk_Date { get; set; }

    public string? Pay_For { get; set; }

    public string? Pay_Desc { get; set; }

    public decimal? Cust_Due { get; set; }

    public decimal? Final_Due { get; set; }

    public string? Pay_Mode { get; set; }
}
