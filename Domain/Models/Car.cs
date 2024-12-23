using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class Car
{
    public int CarId { get; set; }

    public string Make { get; set; } = null!;

    public string Model { get; set; } = null!;

    public int Year { get; set; }

    public decimal Price { get; set; }

    public int Mileage { get; set; }

    public string Color { get; set; } = null!;

    public string EngineType { get; set; } = null!;

    public string Transmission { get; set; } = null!;

    public string FuelType { get; set; } = null!;

    public string BodyType { get; set; } = null!;

    public string? ImageUrl { get; set; }

    public string? SaleLocation { get; set; }

    public virtual ICollection<CarAttribute> CarAttributes { get; set; } = new List<CarAttribute>();

    public virtual ICollection<CarImage> CarImages { get; set; } = new List<CarImage>();

    public virtual ICollection<CarRental> CarRentals { get; set; } = new List<CarRental>();

    public virtual ICollection<CarSale> CarSales { get; set; } = new List<CarSale>();

    public virtual ICollection<ExpertRecommendation> ExpertRecommendations { get; set; } = new List<ExpertRecommendation>();

    public virtual ICollection<MaintenanceRecord> MaintenanceRecords { get; set; } = new List<MaintenanceRecord>();

    public virtual ICollection<Post> Posts { get; set; } = new List<Post>();

    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();

    public virtual ICollection<TechnicalMaintenance> TechnicalMaintenances { get; set; } = new List<TechnicalMaintenance>();

    public virtual ICollection<TestDrife> TestDrives { get; set; } = new List<TestDrife>();
}
