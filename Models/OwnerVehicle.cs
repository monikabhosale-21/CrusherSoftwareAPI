using System;
using System.Collections.Generic;

namespace CrusherSoftwareAPI.Models;

public partial class OwnerVehicle
{
    public int Own_Vehi_Id { get; set; }

    public int Own_Id { get; set; }

    public string Vehicle_No { get; set; } = null!;

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual Owner Own { get; set; } = null!;
}
