using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SisGUAPA.Application.Services.Entidade;
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
                // Windows
                services.AddSingleton<MainWindow>();
                //services.AddTransient<CadastroEntidadeWindow>();

                //Serviços
                services.AddTransient<IEntidadeService, EntidadeService>();  
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