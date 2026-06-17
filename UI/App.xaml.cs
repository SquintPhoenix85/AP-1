using System;
using System.IO;
using System.Windows;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Presupuestos.Application.Interfaces;
using Presupuestos.Application.Services;
using Presupuestos.Domain.Interfaces;
using Presupuestos.Infrastructure.Data;
using Presupuestos.Infrastructure.Repositories;

namespace UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private ServiceProvider? _serviceProvider;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var services = new ServiceCollection();
            ConfigureServices(services);

            _serviceProvider = services.BuildServiceProvider();

            using var scope = _serviceProvider.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            context.Database.EnsureCreated();

            var mainWindow = _serviceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();
        }

        protected override void OnExit(ExitEventArgs e)
        {
            _serviceProvider?.Dispose();
            base.OnExit(e);
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            var dbPath = Path.Combine(AppContext.BaseDirectory, "presupuestos.db");

            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlite($"Data Source={dbPath}"));

            services.AddScoped<IMaterialRepository, MaterialRepository>();
            services.AddScoped<IAPURepository, APURepository>();
            services.AddScoped<IPresupuestoRepository, PresupuestoRepository>();
            services.AddScoped<IEquipoRepository, EquipoRepository>();
            services.AddScoped<IManoObraRepository, ManoObraRepository>();

            services.AddScoped<IMaterialService, MaterialService>();
            services.AddScoped<IAPUService, APUService>();
            services.AddScoped<IPresupuestoService, PresupuestoService>();

            services.AddTransient<MainWindow>();
        }
    }
}
