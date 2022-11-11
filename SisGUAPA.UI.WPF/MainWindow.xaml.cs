using Microsoft.EntityFrameworkCore;
using SisGUAPA.Application.Services.Entidade;
using SisGUAPA.Infra.Data;
using System.Windows;

namespace SisGUAPA.UI.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly SisGUAPAContext _dataBaseContext;
        private readonly IEntidadeService _entidadeService;

        public MainWindow(IEntidadeService entidadeService, SisGUAPAContext dataBaseContext)
        {
            InitializeComponent();
            _entidadeService = entidadeService;
            _dataBaseContext = dataBaseContext;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _dataBaseContext.Database.EnsureCreated();
            _dataBaseContext.Entidades.Load();
            //entidadeViewSource.Source = _sisguapaContext.Entidades.Local.ToObservableCollection();
        }

        private void btnLogar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCriarEntidade_Click(object sender, RoutedEventArgs e)
        {
            var entidadeWindow = new CadastroEntidadeWindow(_entidadeService, _dataBaseContext);
            entidadeWindow.ShowDialog();
        }
    }
}
