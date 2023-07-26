using HRIS.Application.Profiles;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Application
{
    public static class ApplicationServicesRegistration
    {
        public static void ConfigureApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            //services.AddAutoMapper(typeof(MappingProfile));
        }
    }
}
