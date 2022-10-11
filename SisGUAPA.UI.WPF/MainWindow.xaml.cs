using Microsoft.EntityFrameworkCore;
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
        private readonly AnimalContext _animalContext = new AnimalContext();
        private CollectionViewSource entidadeViewSource;

        public MainWindow()
        {
            InitializeComponent();
            entidadeViewSource = (CollectionViewSource)FindResource(nameof(entidadeViewSource));
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _animalContext.Database.EnsureCreated();
            _animalContext.Entidades.Load();
            entidadeViewSource.Source = _animalContext.Entidades.Local.ToObservableCollection();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _animalContext.SaveChanges();
            entidadeDataGrid.Items.Refresh();
            animalDataGrid.Items.Refresh();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            _animalContext.Dispose();
            base.OnClosing(e);
        }
    }
}
