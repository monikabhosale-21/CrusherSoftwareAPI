using System;
using System.Collections.Generic;

namespace CrusherSoftwareAPI.Models;

public partial class Expense
{
    public int Exp_Id { get; set; }

    public DateTime Exp_Date { get; set; }

    public int Cat_Id { get; set; }

    public decimal Amount { get; set; }

    public string? Details { get; set; }

    public int? Bank_Id { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
