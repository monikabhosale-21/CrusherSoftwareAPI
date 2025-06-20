using System;
using System.Collections.Generic;

namespace CrusherSoftwareAPI.Models;

public partial class QuotationTerm
{
    public int Term_Id { get; set; }

    public int Quom_Id { get; set; }

    public string? Terms { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual QuotationMaster Quom { get; set; } = null!;
}
