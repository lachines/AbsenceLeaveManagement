using LeaveApprouvment.Applications.Services;
using LeaveApprouvment.Contracts.IService;
using LeaveApprouvment.Domains.IRepositories;
using LeaveApprouvment.Infrastrectures;
using LeaveApprouvment.Infrastrectures.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveApprouvment.DependencyInjections
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterServicesContainer(this IServiceCollection serviceCollection)
        {
            // serviceCollection;
            serviceCollection.AddScoped<ILeaveRequestService, LeaveRequestService>();
            return serviceCollection;
        }
        public static IServiceCollection RegisterRepositories(this IServiceCollection serviceCollection)
        {
            serviceCollection
           .AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            serviceCollection.AddScoped<ILeaveRequestRepository, LeaveRequestRepository>();

            return serviceCollection;
        }
        public static IServiceCollection RegisterDatabase(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddDbContext<DBContext>(options =>
           options.UseSqlServer(configuration.GetConnectionString("Default")));
            return serviceCollection;
        }
    }
}


