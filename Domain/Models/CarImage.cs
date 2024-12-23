﻿using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class CarImage
{
    public int ImageId { get; set; }

    public int? CarId { get; set; }

    public string ImageUrl { get; set; } = null!;

    public string? Description { get; set; }

    public virtual Car? Car { get; set; }
}
