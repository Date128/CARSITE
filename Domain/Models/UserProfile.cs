using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class UserProfile
{
    public int ProfileId { get; set; }

    public int? UserId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateOnly? BirthDate { get; set; }

    public string? Phone { get; set; }

    public string? Address { get; set; }

    public string? Bio { get; set; }

    public virtual User? User { get; set; }
}
