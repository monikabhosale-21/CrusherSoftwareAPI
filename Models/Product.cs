using System;
using System.Collections.Generic;

namespace CrusherSoftwareAPI.Models;

public partial class Product
{
    public int Prod_Id { get; set; }

    public string? Prod_Name { get; set; }

    public string? Prod_Type { get; set; }

    public string? Unit { get; set; }

    public decimal? Rate { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
