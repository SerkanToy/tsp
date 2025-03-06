using tsp.api.Domain.Abstraction;
using tsp.api.Domain.Core.Base;
using tsp.api.Domain.Repositories;

namespace tsp.api.Domain
{
    public static class ServiceRegistration
    {
        public static void AddCoreServices(this IServiceCollection services, IConfiguration configuration = null) 
        {
            services.AddScoped(typeof(BaseResponseModel));
        }
    }
}
