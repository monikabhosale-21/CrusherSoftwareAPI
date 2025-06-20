using System;
using System.Collections.Generic;

namespace CrusherSoftwareAPI.Models;

public partial class Maintenance
{
    public int Maintenance_Id { get; set; }

    public DateTime Maintenance_Date { get; set; }

    public int Vend_Id { get; set; }

    public int Cat_Id { get; set; }

    public decimal Amount { get; set; }

    public string? Details { get; set; }

    public string? Name { get; set; }

    public string? Mobile { get; set; }

    public decimal? Due_Amount { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
