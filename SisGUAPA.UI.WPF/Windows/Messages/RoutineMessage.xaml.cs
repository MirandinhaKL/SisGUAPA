using System.Windows;

/*
 * Copied in: 08-01-2023
 * From: https://stackoverflow.com/questions/56376748/messagebox-in-material-design-wpf-c-sharp
 * Origin: https://github.com/sandeepjadhav75502/CustomMessageBoxWPF/blob/main/CustomMessageBox/MainWindow.xaml
 */
namespace SisGUAPA.UI.WPF.Windows.Messages
{
    /// <summary>
    /// Lógica interna para RoutineMessage.xaml
    /// </summary>
    public partial class RoutineMessage : Window
    {
        public RoutineMessage(string Message, MessageType Type, MessageButtons Buttons)
        {
            InitializeComponent();
            txtMessage.Text = Message;
            
            switch (Type)
            {
                case MessageType.Info:
                    txtTitle.Text = "Informação";
                    break;
                case MessageType.Confirmation:
                    txtTitle.Text = "Confirmação";
                    break;
                case MessageType.Success:
                        txtTitle.Text = "Sucesso";
                    break;
                case MessageType.Warning:
                    txtTitle.Text = "Atenção";
                    break;
                case MessageType.Error:
                    txtTitle.Text = "Erro";
                    break;
            }
            switch (Buttons)
            {
                case MessageButtons.OkCancel:
                    btnYes.Visibility = Visibility.Collapsed; btnNo.Visibility = Visibility.Collapsed;
                    break;
                case MessageButtons.YesNo:
                    btnOk.Visibility = Visibility.Collapsed; btnCancel.Visibility = Visibility.Collapsed;
                    break;
                case MessageButtons.Ok:
                    btnOk.Visibility = Visibility.Visible;
                    btnCancel.Visibility = Visibility.Collapsed;
                    btnYes.Visibility = Visibility.Collapsed; btnNo.Visibility = Visibility.Collapsed;
                    break;
            }
        }

        private void btnYes_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }

        private void btnNo_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }

    public enum MessageType
    {
        Info,
        Confirmation,
        Success,
        Warning,
        Error,
    }

    public enum MessageButtons
    {
        OkCancel,
        YesNo,
        Ok,
    }
}