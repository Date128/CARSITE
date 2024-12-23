using Domain.Interfaces;
using Domain.Models;

namespace DataAccess.Repositories
{
    public class NotificationRepository : RepositoryBase<Notification>, INotificationRepository
    {
        public NotificationRepository(CarsiteContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}