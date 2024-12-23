using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class User
{
    public int UserId { get; set; }

    public string Username { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public DateTime? RegistrationDate { get; set; }

    public string Role { get; set; } = null!;

    public virtual ICollection<CarRental> CarRentals { get; set; } = new List<CarRental>();

    public virtual ICollection<CarSale> CarSaleBuyers { get; set; } = new List<CarSale>();

    public virtual ICollection<CarSale> CarSaleSellers { get; set; } = new List<CarSale>();

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual ICollection<ExpertRecommendation> ExpertRecommendations { get; set; } = new List<ExpertRecommendation>();

    public virtual ICollection<MaintenanceRecord> MaintenanceRecords { get; set; } = new List<MaintenanceRecord>();

    public virtual ICollection<Notification> Notifications { get; set; } = new List<Notification>();

    public virtual ICollection<Post> Posts { get; set; } = new List<Post>();

    public virtual ICollection<Rating> Ratings { get; set; } = new List<Rating>();

    public virtual ICollection<UserProfile> UserProfiles { get; set; } = new List<UserProfile>();
}
