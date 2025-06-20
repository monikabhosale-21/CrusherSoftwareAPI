using System;
using System.Collections.Generic;

namespace CrusherSoftwareAPI.Models;

public partial class PumpDieselEntry
{
    public int Pump_Diesel_Id { get; set; }

    public DateTime Diesel_Date { get; set; }

    public int Pump_Id { get; set; }

    public string? Vehicle_No { get; set; }

    public decimal? Reading { get; set; }

    public decimal? Diesel { get; set; }

    public decimal? Amount { get; set; }

    public decimal? Rate { get; set; }

    public string? Name { get; set; }

    public string? Mobile { get; set; }

    public decimal? Due_Amt { get; set; }

    public decimal? Final_Due_Amt { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
