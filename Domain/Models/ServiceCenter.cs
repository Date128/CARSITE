using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class ServiceCenter
{
    public int CenterId { get; set; }

    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public virtual ICollection<MaintenanceService> MaintenanceServices { get; set; } = new List<MaintenanceService>();

    public virtual ICollection<TechnicalMaintenance> TechnicalMaintenances { get; set; } = new List<TechnicalMaintenance>();
}
