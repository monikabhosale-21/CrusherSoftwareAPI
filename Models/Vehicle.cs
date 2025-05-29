using System;
using System.Collections.Generic;

namespace CrusherSoftwareAPI.Models;

public partial class Vehicle
{
    public int VehicleId { get; set; }

    public string? VehicleNo { get; set; }

    public string? Emptyweight { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
