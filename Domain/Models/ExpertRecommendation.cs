using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class ExpertRecommendation
{
    public int RecommendationId { get; set; }

    public int? ExpertId { get; set; }

    public int? CarId { get; set; }

    public virtual Car? Car { get; set; }

    public virtual User? Expert { get; set; }

    public virtual Post Recommendation { get; set; } = null!;
}
//IExpertRecommendationRepository