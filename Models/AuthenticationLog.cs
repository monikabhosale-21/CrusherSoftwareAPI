using System;
using System.Collections.Generic;

namespace CrusherSoftwareAPI.Models;

public partial class AuthenticationLog
{
    public int LogId { get; set; }

    public int UserId { get; set; }

    public DateTime? AttemptedAt { get; set; }

    public string? IpAddress { get; set; }

    public bool? Successful { get; set; }

    public bool IsActive { get; set; }

    public int? Createdby { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? Updatedby { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
