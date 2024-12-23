using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class Tag
{
    public int TagId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<PostTag> PostTags { get; set; } = new List<PostTag>();
}
