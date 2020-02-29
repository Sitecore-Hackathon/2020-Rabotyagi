using Glass.Mapper.Sc.Web.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;

namespace Hackathon.Foundation.GlassMapper.DI
{
    public class RegisterContainer : IServicesConfigurator
    {
        /// <inheritdoc />
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IMvcContext, MvcContext>();
        }
    }
}