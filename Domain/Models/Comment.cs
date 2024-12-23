using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class Comment
{
    public int CommentId { get; set; }

    public string Content { get; set; } = null!;

    public DateTime? PublicationDate { get; set; }

    public int? UserId { get; set; }

    public int? PostId { get; set; }

    public string PostType { get; set; } = null!;

    public virtual Post? Post { get; set; }

    public virtual User? User { get; set; }
}
