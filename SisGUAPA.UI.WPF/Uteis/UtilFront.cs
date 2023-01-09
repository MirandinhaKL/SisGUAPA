using SisGUAPA.Application.Util;
using SisGUAPA.UI.WPF.Windows.Messages;

namespace SisGUAPA.UI.WPF.Uteis
{
    static class UtilFront
    {
        /// <summary>
        /// Mensagem exibida ao usuário quando alguma operação do banco de dados for realizada.
        /// </summary>
        public static void SuccessMessageCRUD(EnumerationsFront.MensagemCRUDTextoPassado acaoMensagem)
        {
            var message = $"Os dados foram {acaoMensagem.GetDescricaoEnum()} com sucesso.";
            new RoutineMessage(message, MessageType.Info, MessageButtons.Ok).ShowDialog();
        }

        /// <summary>
        /// Mensagem exibida ao usuário quando alguma operação do banco de dados for realizada com erro.
        /// </summary>
        public static void FailMessageCRUD(EnumerationsFront.MensagemCRUDTextoVerbo acaoMensagem)
        {
            var message = $"Falha ao {acaoMensagem.GetDescricaoEnum()} os dados.";
            new RoutineMessage(message, MessageType.Error, MessageButtons.Ok).ShowDialog();
        }
    }
}