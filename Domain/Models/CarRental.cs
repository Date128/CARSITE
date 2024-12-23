using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class CarRental
{
    public int RentalId { get; set; }

    public int? CarId { get; set; }

    public int? UserId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public decimal PricePerDay { get; set; }

    public string Status { get; set; } = null!;

    public virtual Car? Car { get; set; }

    public virtual User? User { get; set; }
}
