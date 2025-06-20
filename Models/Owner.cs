using System;
using System.Collections.Generic;

namespace CrusherSoftwareAPI.Models;

public partial class Owner
{
    public int Own_Id { get; set; }

    public string Own_Name { get; set; } = null!;

    public string Own_Mobile { get; set; } = null!;

    public string? Own_Email { get; set; }

    public string? Own_City { get; set; }

    public string? Vehicle_No { get; set; }

    public decimal? Own_Due { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<OwnerVehicle> OwnerVehicles { get; set; } = new List<OwnerVehicle>();
}
