using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class TestDrife
{
    public int TestDriveId { get; set; }

    public int? CarId { get; set; }

    public virtual Car? Car { get; set; }

    public virtual Post TestDrive { get; set; } = null!;
}
