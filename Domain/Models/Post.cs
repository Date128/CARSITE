using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class Post
{
    public int PostId { get; set; }

    public string Title { get; set; } = null!;

    public string Content { get; set; } = null!;

    public DateTime? PublicationDate { get; set; }

    public int? AuthorId { get; set; }

    public string PostType { get; set; } = null!;

    public int? CarId { get; set; }

    public int? CategoryId { get; set; }

    public virtual User? Author { get; set; }

    public virtual Car? Car { get; set; }

    public virtual Category? Category { get; set; }

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual ExpertRecommendation? ExpertRecommendation { get; set; }

    public virtual News? News { get; set; }

    public virtual ICollection<PostTag> PostTags { get; set; } = new List<PostTag>();

    public virtual ICollection<Rating> Ratings { get; set; } = new List<Rating>();

    public virtual Review? Review { get; set; }

    public virtual TestDrife? TestDrife { get; set; }
}
