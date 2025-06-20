using System;
using System.Collections.Generic;

namespace CrusherSoftwareAPI.Models;

public partial class Vendor
{
    public int VendId { get; set; }

    public string? VendName { get; set; }

    public string? Mobile { get; set; }

    public string? City { get; set; }

    public string? Address { get; set; }

    public string? GSTNo { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
