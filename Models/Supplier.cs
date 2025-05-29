using System;
using System.Collections.Generic;

namespace CrusherSoftwareAPI.Models;

public partial class Supplier
{
    public int SupplierId { get; set; }

    public string? SupplierName { get; set; }

    public string? Mobile { get; set; }

    public int? CityId { get; set; }

    public string? Opening_Payable { get; set; }

    public string? Supplier_Address { get; set; }

    public bool? IsActive { get; set; }

    public int? Createdby { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? Updatedby { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
