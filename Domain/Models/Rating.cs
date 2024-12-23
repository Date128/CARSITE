using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class Rating
{
    public int RatingId { get; set; }

    public int? UserId { get; set; }

    public int? PostId { get; set; }

    public int Rating1 { get; set; }

    public virtual Post? Post { get; set; }

    public virtual User? User { get; set; }
}
