using System;
using System.Collections.Generic;

namespace CrusherSoftwareAPI.Models;

public partial class PurchaseVehicle
{
    public int VehicleId { get; set; }

    public int PurmId { get; set; }

    public string? VehicleNo { get; set; }

    public decimal? EmptyWeight { get; set; }

    public decimal? Morang { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual PurchaseMaster Purm { get; set; } = null!;
}
