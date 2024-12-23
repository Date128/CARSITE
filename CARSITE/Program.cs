
using Domain.Interfaces;
using BusinessLogic.Services;
using Domain.Models;
using DataAccess.Wrapper;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Domain.Wrapper;

namespace CARSITE
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<CarsiteContext>(options => options.UseSqlServer("Server=EMPIRE;Database=CARSITE;Trusted_Connection=True;TrustServerCertificate=True;"));
            builder.Services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
            builder.Services.AddScoped<IUserService, UserService>();
            builder.Services.AddScoped<ICarServices, CarService>();
            builder.Services.AddScoped<IPostService, PostService>();
            builder.Services.AddScoped<ICategoryService, CategoryService>();
            builder.Services.AddScoped<ICommentService, CommentService>();
            builder.Services.AddScoped<ICarRentalService, CarRentalService>();
            builder.Services.AddScoped<ICarSaleService, CarSaleService>();
            builder.Services.AddScoped<IMaintenanceRecordService, MaintenanceRecordService>();
            builder.Services.AddScoped<IServiceCenterService, ServiceCenterService>();
            builder.Services.AddScoped<IMaintenanceServiceService, MaintenanceServiceService>();
            builder.Services.AddScoped<IUserProfileService, UserProfileService>();
            builder.Services.AddScoped<ICarImageService, CarImageService>();
            builder.Services.AddScoped<ITagService, TagService>();
            builder.Services.AddScoped<IPostTagService, PostTagService>();
            builder.Services.AddScoped<INotificationService, NotificationService>();
            builder.Services.AddScoped<IRatingService, RatingService>();
            builder.Services.AddScoped<ITechnicalMaintenanceService, TechnicalMaintenanceService>();
            builder.Services.AddScoped<ICarAttributeService, CarAttributeService>();
            builder.Services.AddScoped<IAttributeServise, AttributeServise>();
            builder.Services.AddScoped<INewsService, NewsService>();
            builder.Services.AddScoped<IReviewService, ReviewService>();
            builder.Services.AddScoped<ITestDriveService, TestDriveService>();
            builder.Services.AddScoped<IExpertRecommendationService, ExpertRecommendationService>();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}