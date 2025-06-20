using System;
using System.Collections.Generic;

namespace CrusherSoftwareAPI.Models;

public partial class Vehicle
{
    public int Vehicle_Id { get; set; }

    public string Vehicle_No { get; set; } = null!;

    public decimal? Empty_Weight { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
