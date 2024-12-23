using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class News
{
    public int NewsId { get; set; }

    public int? CategoryId { get; set; }

    public virtual Category? Category { get; set; }

    public virtual Post NewsNavigation { get; set; } = null!;
}
