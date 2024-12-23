using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class TechnicalMaintenance
{
    public int MaintenanceId { get; set; }

    public int? CarId { get; set; }

    public int? ServiceCenterId { get; set; }

    public DateTime MaintenanceDate { get; set; }

    public string Description { get; set; } = null!;

    public decimal Cost { get; set; }

    public virtual Car? Car { get; set; }

    public virtual ServiceCenter? ServiceCenter { get; set; }
}
