using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SisGUAPA.Application.Services;
using SisGUAPA.Application.Services.Entidade;
using SisGUAPA.Domain.Entities;
using SisGUAPA.Infra.Data;
using System.Windows;
namespace SisGUAPA.UI.WPF;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : System.Windows.Application
{
    /* Para a configuração da injeção de dependênica instalar:
     * Microsoft.Extensions.DependecyInjection
     * Microsoft.Extensions.Hosting
     */
    public static IHost? AppHost { get; private set; }

    public App()
    {
        AppHost = Host.CreateDefaultBuilder()
            .ConfigureServices((hostContext, services) =>
            {
                //Configurações
                services.AddDbContext<SisGUAPAContext>(options =>
                {
                    options.UseSqlite("Data Source=sisguapa_sqlite.db");
                });

                // Telas
                services.AddSingleton<MainWindow>();
                services.AddTransient<CadastroEntidadeWindow>();

                //Serviços entidades
                services.AddTransient<IEntidadeService, EntidadeService>();

                // Serviços validatores
                services.AddScoped<IValidator<Entity>, EntidadeValidator>();
            })
            .Build();
    }

    protected override async void OnStartup(StartupEventArgs e)
    {
        await AppHost!.StartAsync();

        var starupForm = AppHost.Services.GetRequiredService<MainWindow>();
        starupForm.Show();

        base.OnStartup(e);
    }

    protected override async void OnExit(ExitEventArgs e)
    {
        await AppHost!.StopAsync();
        base.OnExit(e);
    }
}