using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class Attribute
{
    public int AttributeId { get; set; }

    public string TypeValue { get; set; } = null!;

    public string Name { get; set; } = null!;

    public virtual ICollection<CarAttribute> CarAttributes { get; set; } = new List<CarAttribute>();
}
