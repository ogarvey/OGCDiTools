using Desktop.Interfaces;
using Desktop.Models;
using Desktop.Models.Repository;
using Desktop.Views.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Desktop
{
  internal static class Program
  {
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      var host = Host.CreateDefaultBuilder()
            .ConfigureServices((_, services) =>
            {
              ConfigureServices(services);
            })
            .Build();

      using var serviceScope = host.Services.CreateScope();
      var services = serviceScope.ServiceProvider;
      // To customize application configuration such as set high DPI settings or default font,
      // see https://aka.ms/applicationconfiguration.
      //ApplicationConfiguration.Initialize();
      //Application.Run(new MainWindow());
      try
      {
        var form1 = services.GetRequiredService<MainWindow>();
        Application.Run(form1);
      }
      catch (Exception ex)
      {
        // Handle exceptions as needed
      }
    }
    private static void ConfigureServices(IServiceCollection services)
    {
      var configuration = services.BuildServiceProvider().GetRequiredService<IConfiguration>();
      services.AddDbContext<PlanetConfigContext>(options => options.UseSqlite(configuration.GetConnectionString("planetConfig")));

      // Register your DataFileRepository implementation and other services here
      services.AddSingleton<IDataFileRepository, DataFileRepository>();

      // Register your forms here
      services.AddTransient<MainWindow>();
      services.AddTransient<MainDataForm>();
      // services.AddTransient<OtherForm>();
    }
  }
}