using System;
using System.Collections.Generic;

namespace CrusherSoftwareAPI.Models;

public partial class Owner
{
    public int OwnerId { get; set; }

    public string? OwnerName { get; set; }

    public string? Mobile { get; set; }

    public int? CityId { get; set; }

    public string? Dues { get; set; }

    public bool? IsActive { get; set; }

    public int? Createdby { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? Updatedby { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
