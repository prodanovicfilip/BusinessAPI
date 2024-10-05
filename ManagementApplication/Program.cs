using ManagementApplication.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ManagementApplication
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            LoginForm form = null; 
            RegisterServices(); 
            BuildServiceProvider(out form); 

            Application.Run(form);
        }
        private static IServiceCollection services { get; set; } = new ServiceCollection();
        private static ServiceProvider serviceProvider { get; set; }
        public static void BuildServiceProvider(out LoginForm form)
        {
            serviceProvider = services.BuildServiceProvider();
            form = serviceProvider.GetRequiredService<LoginForm>();
        }
        public static T GetService<T>()
        {
            return (T)serviceProvider.GetRequiredService<T>();
        }
        public static void RegisterServices()
        {
            services.AddDbContext<BusinessContext>();
            services.AddTransient<LoginForm>();
            services.AddTransient<RegistrationForm>();
            services.AddTransient<MainForm>();
            services.AddTransient<UserProfile>();
            services.AddTransient<CreateClient>();
            services.AddTransient<UserManagement>();
            services.AddTransient<EmployeeForm>();
            services.AddTransient<POSForm>();
            services.AddSingleton<HttpClient>();
            services.AddSingleton<IApiService, ApiService>();
        }
    }
}