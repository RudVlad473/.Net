using Class_Library;
using Microsoft.Extensions.DependencyInjection;
using Windows_Forms_App.Classes;

namespace Windows_Forms_App
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();
            ConfigureServices(services);

            ApplicationConfiguration.Initialize();
            Application.Run(new SelectAtmForm());
        }

        public static void ConfigureServices(IServiceCollection services)
        {
            var mockBank = MockBank.GetMockBank();

            var appState = AppState.Instance;
            appState.Initialize(mockBank, new WindowNotificationSender().SendNotification);

            appState.Notification.AddNotify(new EmailNotificationSender().SendNotification);

            services.AddSingleton(appState);
        }
    }
}
