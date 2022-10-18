using Microsoft.EntityFrameworkCore;
using SisGUAPA.Application.Services.Entidade;
using SisGUAPA.Infra.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SisGUAPA.UI.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly SisGUAPAContext _sisguapaContext = new SisGUAPAContext();
        private readonly IEntidadeService _entidadeService;

        public MainWindow(IEntidadeService entidadeService)
        {
            InitializeComponent();
            _entidadeService = entidadeService;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //_sisguapaContext.Database.EnsureCreated();
            //_sisguapaContext.Entidades.Load();
            //entidadeViewSource.Source = _sisguapaContext.Entidades.Local.ToObservableCollection();
        }

        private void btnLogar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCriarEntidade_Click(object sender, RoutedEventArgs e)
        {
            var entidadeWindow = new CadastroEntidadeWindow(_entidadeService);
            entidadeWindow.ShowDialog();
        }
    }
}
