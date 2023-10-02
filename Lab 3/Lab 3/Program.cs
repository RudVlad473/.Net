using Microsoft.Extensions.DependencyInjection;
using Model;
using System.Configuration;
using System.Net.NetworkInformation;

namespace Lab_3
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var serviceCollection = new ServiceCollection();

            var services = ConfigureServices(serviceCollection);

            var dbContext = services.GetService<StoreContext>();

            ApplicationConfiguration.Initialize();
            Application.Run(new SelectForm(dbContext));
        }

        public static ServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<StoreContext>();

            return services.BuildServiceProvider();
        }
    }
}
