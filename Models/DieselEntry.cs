using System;
using System.Collections.Generic;

namespace CrusherSoftwareAPI.Models;

public partial class DieselEntry
{
    public int DieselEntryId { get; set; }

    public string? PetrolPump { get; set; }

    public string? Mobile { get; set; }

    public string? Vehicle { get; set; }

    public string? Reading { get; set; }

    public decimal? Diesel_Petrol { get; set; }

    public decimal? Amount { get; set; }

    public bool? IsActive { get; set; }

    public int? Createdby { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? Updatedby { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
