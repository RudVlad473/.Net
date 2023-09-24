using Class_Library;
using Microsoft.Extensions.DependencyInjection;

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
            appState.Initialize(
                mockBank,
                (message) => MessageBox.Show(message.Content, message.Header)
            );

            services.AddSingleton(appState);
        }
    }
}
