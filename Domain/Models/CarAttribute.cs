using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class CarAttribute
{
    public int CarId { get; set; }

    public int AttributeId { get; set; }

    public string Value { get; set; } = null!;

    public virtual Attribute Attribute { get; set; } = null!;

    public virtual Car Car { get; set; } = null!;
}
