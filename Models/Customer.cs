using System;
using System.Collections.Generic;

namespace CrusherSoftwareAPI.Models;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string? CustomerName { get; set; }

    public string? Mobile { get; set; }

    public int? CityId { get; set; }

    public string? CityName { get; set; }

    public string? OpeningDues { get; set; }

    public string? CustomerAddress { get; set; }

    public bool IsActive { get; set; }

    public int? Createdby { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? Updatedby { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
