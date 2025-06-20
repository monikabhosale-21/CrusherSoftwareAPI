using System;
using System.Collections.Generic;

namespace CrusherSoftwareAPI.Models;

public partial class Category
{
    public int Cat_Id { get; set; }

    public string Category_Name { get; set; } = null!;

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
