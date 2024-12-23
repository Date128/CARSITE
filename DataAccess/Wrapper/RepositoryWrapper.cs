using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Domain.Interfaces;
using DataAccess.Repositories;
using Domain.Wrapper;

namespace DataAccess.Wrapper
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private CarsiteContext _repoContext;

        private IUserRepository _user;
        private ICarRepository _car;
        private ICategoryRepository _category;
        private IAttributeRepository _attribute;
        private ICarAttributeRepository _carAttribute;
        private ICarImageRepository _carImage;
        private ICarRentalRepository _carRental;
        private ICarSaleRepository _carSale;
        private ICommentRepository _comment;
        private INewsRepository _news;
        private IPostRepository _post;
        private IPostTagRepository _postTag;
        private IRatingRepository _rating;
        private IReviewRepository _review;
        private IServiceCenterRepository _serviceCenter;
        private ITagRepository _tag;
        private ITechnicalMaintenanceRepository _technicalMaintenance;
        private ITestDrifeRepository _testDrife;
        private IUserProfileRepository _userProfile;
        private IExpertRecommendationRepository _expertRecommendation;
        private IMaintenanceRecordRepository _maintenanceRecord;
        private IMaintenanceServiceRepository _maintenanceService;
        private INotificationRepository _notification;

        public INotificationRepository Notification
        {
            get
            {
                if(_notification == null)
                {
                    _notification = new NotificationRepository(_repoContext);
                }
                return _notification;
            }
        }

        public IMaintenanceServiceRepository MaintenanceService
        {
            get
            {
                if (_maintenanceService == null)
                {
                    _maintenanceService = new MaintenanceServiceRepository(_repoContext);
                }
                return _maintenanceService;
            }
        }

        public IMaintenanceRecordRepository MaintenanceRecord
        {
            get
            {
                if (_maintenanceRecord == null)
                {
                    _maintenanceRecord = new MaintenanceRecordRepository(_repoContext);
                }
                return _maintenanceRecord;
            }
        }

        public IExpertRecommendationRepository ExpertRecommendation
        {
            get
            {
                if (_user == null)
                {
                    _expertRecommendation = new ExpertRecommendationRepository(_repoContext);
                }
                return _expertRecommendation;
            }
        }

        public IUserRepository User
        {
            get
            {
                if (_user == null)
                {
                    _user = new UserRepository(_repoContext);
                }
                return _user;
            }
        }

        public ICarRepository Car
        {
            get
            {
                if (_car == null)
                {
                    _car = new CarRepository(_repoContext);
                }
                return _car;
            }
        }

        public ICategoryRepository Category
        {
            get
            {
                if (_category == null)
                {
                    _category = new CategoryRepository(_repoContext);
                }
                return _category;
            }
        }

        public ITagRepository Tag
        {
            get
            {
                if (_tag == null)
                {
                    _tag = new TagRepository(_repoContext);
                }
                return _tag;
            }
        }

        public IAttributeRepository Attribute
        {
            get
            {
                if (_attribute == null)
                {
                    _attribute = new AttributeRepository(_repoContext);
                }
                return _attribute;
            }
        }

        public ICarAttributeRepository CarAttribute
        {
            get
            {
                if (_carAttribute == null)
                {
                    _carAttribute = new CarAttributeRepository(_repoContext);
                }
                return _carAttribute;
            }
        }

        public ICarImageRepository CarImage
        {
            get
            {
                if (_carImage == null)
                {
                    _carImage = new CarImageRepository(_repoContext);
                }
                return _carImage;
            }
        }

        public ICarRentalRepository CarRental
        {
            get
            {
                if (_carRental == null)
                {
                    _carRental = new CarRentalRepository(_repoContext);
                }
                return _carRental;
            }
        }

        public ICarSaleRepository CarSale
        {
            get
            {
                if (_carSale == null)
                {
                    _carSale = new CarSaleRepository(_repoContext);
                }
                return _carSale;
            }
        }

        public ICommentRepository Comment
        {
            get
            {
                if (_comment == null)
                {
                    _comment = new CommentRepository(_repoContext);
                }
                return _comment;
            }
        }

        public INewsRepository News
        {
            get
            {
                if (_news == null)
                {
                    _news = new NewsRepository(_repoContext);
                }
                return _news;
            }
        }

        public IPostRepository Post
        {
            get
            {
                if (_post == null)
                {
                    _post = new PostRepository(_repoContext);
                }
                return _post;
            }
        }

        public IPostTagRepository PostTag
        {
            get
            {
                if (_postTag == null)
                {
                    _postTag = new PostTagRepository(_repoContext);
                }
                return _postTag;
            }
        }

        public IRatingRepository Rating
        {
            get
            {
                if (_rating == null)
                {
                    _rating = new RatingRepository(_repoContext);
                }
                return _rating;
            }
        }

        public IReviewRepository Review
        {
            get
            {
                if (_review == null)
                {
                    _review = new ReviewRepository(_repoContext);
                }
                return _review;
            }
        }


        public IServiceCenterRepository ServiceCenter
        {
            get
            {
                if (_serviceCenter == null)
                {
                    _serviceCenter = new ServiceCenterRepository(_repoContext);
                }
                return _serviceCenter;
            }
        }

        public ITechnicalMaintenanceRepository TechnicalMaintenance
        {
            get
            {
                if (_technicalMaintenance == null)
                {
                    _technicalMaintenance = new TechnicalMaintenanceRepository(_repoContext);
                }
                return _technicalMaintenance;
            }
        }

        public ITestDrifeRepository TestDrife
        {
            get
            {
                if (_testDrife == null)
                {
                    _testDrife = new TestDrifeRepository(_repoContext);
                }
                return _testDrife;
            }
        }

        public IUserProfileRepository UserProfile
        {
            get
            {
                if (_userProfile == null)
                {
                    _userProfile = new UserProfileRepository(_repoContext);
                }
                return _userProfile;
            }
        }

        public RepositoryWrapper(CarsiteContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }

        public async Task Save()
        {
            await _repoContext.SaveChangesAsync();
        }
    }
}