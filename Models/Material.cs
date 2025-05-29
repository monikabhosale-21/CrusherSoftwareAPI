using System;
using System.Collections.Generic;

namespace CrusherSoftwareAPI.Models;

public partial class Material
{
    public int MaterialId { get; set; }

    public string? MaterialName { get; set; }

    public string? MaterialType_Sale_purchase_ { get; set; }

    public decimal? Rate { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
