using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class CarSale
{
    public int SaleId { get; set; }

    public int? CarId { get; set; }

    public int? SellerId { get; set; }

    public int? BuyerId { get; set; }

    public DateTime? SaleDate { get; set; }

    public decimal Price { get; set; }

    public string Status { get; set; } = null!;

    public virtual User? Buyer { get; set; }

    public virtual Car? Car { get; set; }

    public virtual User? Seller { get; set; }
}
