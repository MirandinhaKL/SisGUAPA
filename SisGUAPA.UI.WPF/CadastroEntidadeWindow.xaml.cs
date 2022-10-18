using SisGUAPA.Application.Services.Entidade;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace SisGUAPA.UI.WPF
{
    /// <summary>
    /// Lógica interna para CadastroEntidadeWindow.xaml
    /// </summary>
    public partial class CadastroEntidadeWindow : Window
    {
        private readonly IEntidadeService _entidadeService;

        private Dictionary<int, string> _tiposEntidade;

        public CadastroEntidadeWindow(IEntidadeService entidadeService)
        {
            InitializeComponent();
            _entidadeService = entidadeService;
            _tiposEntidade = _entidadeService.GetTiposEntidade();
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CadastroEntidade_Loaded(object sender, RoutedEventArgs e)
        {
            CarregarTiposEntidade();   
        }

        private void CarregarTiposEntidade()
        {
            foreach (var item in _tiposEntidade)
                cbTipoEntidade.Items.Insert(item.Key, item.Value);
        }
    }
}
