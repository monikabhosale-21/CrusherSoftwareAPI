using System;
using System.Collections.Generic;

namespace CrusherSoftwareAPI.Models;

public partial class TripSelection
{
    public int TripSelectionId { get; set; }

    public string? TripSelectionName { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
