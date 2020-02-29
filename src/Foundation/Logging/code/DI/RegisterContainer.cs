using Hackathon.Foundation.Logging.Services.Implementation;
using Hackathon.Foundation.Logging.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;

namespace Hackathon.Foundation.Logging.DI
{
    public class RegisterContainer : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<ILogger, Logger>();
        }
    }
}