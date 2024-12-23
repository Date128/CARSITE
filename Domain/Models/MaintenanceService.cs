using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class MaintenanceService
{
    public int ServiceId { get; set; }

    public int? CenterId { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public decimal Price { get; set; }

    public virtual ServiceCenter? Center { get; set; }
}
