using System;
using System.Collections.Generic;

namespace CrusherSoftwareAPI.Models;

public partial class PetrolPump
{
    public int Pump_Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Mobile { get; set; }

    public string? City { get; set; }

    public string? Address { get; set; }

    public decimal? Open_Due { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
