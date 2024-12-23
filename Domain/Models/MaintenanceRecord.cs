using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class MaintenanceRecord
{
    public int RecordId { get; set; }

    public int? CarId { get; set; }

    public int? UserId { get; set; }

    public DateTime ServiceDate { get; set; }

    public string Description { get; set; } = null!;

    public decimal Cost { get; set; }

    public virtual Car? Car { get; set; }

    public virtual User? User { get; set; }
}
