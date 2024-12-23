using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class Category
{
    public int CategoryId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<News> News { get; set; } = new List<News>();

    public virtual ICollection<Post> Posts { get; set; } = new List<Post>();
}
