using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class Review
{
    public int ReviewId { get; set; }

    public int? CarId { get; set; }

    public virtual Car? Car { get; set; }

    public virtual Post ReviewNavigation { get; set; } = null!;
}
