using SisGUAPA.Application.Util;
using System.Windows;

namespace SisGUAPA.UI.WPF.Uteis
{
    static class FuncoesGeraisFront
    {
        private static string GetTituloMensagem(EnumeracoesFront.AcaoCRUD acao)
        {
            switch ((int)acao)
            {
                case (int)EnumeracoesFront.AcaoCRUD.Salvar:
                    return "Novo registro";
                case (int)EnumeracoesFront.AcaoCRUD.Editar:
                    return "Editar registro";
                case (int)EnumeracoesFront.AcaoCRUD.Excluir:
                    return "Excluir registro";
                default:
                    return string.Empty;
            }
        }

        /// <summary>
        /// Mensagem exibida ao usuário quando alguma operação do banco de dados for realizada.
        /// </summary>
        public static void MensagemCRUDSucesso(EnumeracoesFront.AcaoCRUD acaoCRUD, EnumeracoesFront.MensagemCRUDTextoPassado acaoMensagem)
        {
            var titulo = GetTituloMensagem(acaoCRUD);
            var mensagem = $"Os dados foram {acaoMensagem.GetDescricaoEnum()} com sucesso.";
            var icone = MessageBoxImage.Information;
            var botoes = MessageBoxButton.OK;
            MessageBox.Show(mensagem, titulo, botoes, icone);
        }


        /// <summary>
        /// Mensagem exibida ao usuário quando alguma operação do banco de dados for realizada com erro.
        /// </summary>
        public static void MensagemCRUDFalha(EnumeracoesFront.AcaoCRUD acaoCRUD, EnumeracoesFront.MensagemCRUDTextoVerbo acaoMensagem)
        {
            var titulo = GetTituloMensagem(acaoCRUD);
            var mensagem = $"Falha ao {acaoMensagem.GetDescricaoEnum()} os dados.";
            var icone = MessageBoxImage.Error;
            var botoes = MessageBoxButton.OK;
            MessageBox.Show(mensagem, titulo, botoes, icone);
        }
    }
}