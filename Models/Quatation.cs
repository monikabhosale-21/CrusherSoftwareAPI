using System;
using System.Collections.Generic;

namespace CrusherSoftwareAPI.Models;

public partial class Quatation
{
    public int QuatationId { get; set; }

    public int? Qt_No { get; set; }

    public DateTime? Qt_Date { get; set; }

    public string? Reference { get; set; }

    public int CustomerId { get; set; }

    public string? CustomerName { get; set; }

    public string? Contact_No { get; set; }

    public string? Location { get; set; }

    public int? TripId { get; set; }

    public string? TripSelection { get; set; }

    public string? Material_Name { get; set; }

    public double? Qty { get; set; }

    public string? Unit { get; set; }

    public decimal? Amount { get; set; }

    public bool? IsActive { get; set; }

    public int? Createdby { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? Updatedby { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
