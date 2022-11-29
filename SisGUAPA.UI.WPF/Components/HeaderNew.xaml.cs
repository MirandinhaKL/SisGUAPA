using System.Windows;
using System.Windows.Controls;

namespace SisGUAPA.UI.WPF.Components
{
    /// <summary>
    /// Interação lógica para HeaderNew.xam
    /// </summary>
    public partial class HeaderNew : UserControl
    {
        //propdp -> atalho que cria  estrutura de dependencia de propriedade.

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Title.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(HeaderNew), new PropertyMetadata(string.Empty));


        public HeaderNew()
        {
            InitializeComponent();
        }
    }
}
