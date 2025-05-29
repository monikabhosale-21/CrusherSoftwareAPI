using System;
using System.Collections.Generic;

namespace CrusherSoftwareAPI.Models;

public partial class PetrolPump
{
    public int PetrolPumpId { get; set; }

    public string? PetrolPumpName { get; set; }

    public string? Mobile { get; set; }

    public int? CityId { get; set; }

    public string? Opening_Payable { get; set; }

    public bool? IsActive { get; set; }

    public int? Createdby { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? Updatedby { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
