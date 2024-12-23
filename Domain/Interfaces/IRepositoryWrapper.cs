using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Interfaces;

namespace Domain.Wrapper
{
    public interface IRepositoryWrapper
    {
        IUserRepository User { get; }
        ICarRepository Car { get; }
        ICategoryRepository Category { get; }
        ITagRepository Tag { get; }
        IAttributeRepository Attribute { get; }
        ICarAttributeRepository CarAttribute { get; }
        ICarImageRepository CarImage { get; }
        ICarRentalRepository CarRental { get; }
        ICarSaleRepository CarSale { get; }
        ICommentRepository Comment { get; }
        INewsRepository News { get; }
        IPostRepository Post { get; }
        IPostTagRepository PostTag { get; }
        IRatingRepository Rating { get; }
        IReviewRepository Review { get; }
        IServiceCenterRepository ServiceCenter { get; }
        ITechnicalMaintenanceRepository TechnicalMaintenance { get; }
        ITestDrifeRepository TestDrife { get; }
        IUserProfileRepository UserProfile { get; }
        IExpertRecommendationRepository ExpertRecommendation { get; }
        IMaintenanceRecordRepository MaintenanceRecord { get; }
        IMaintenanceServiceRepository MaintenanceService { get; }
        INotificationRepository Notification { get; }

        Task Save();
    }
}