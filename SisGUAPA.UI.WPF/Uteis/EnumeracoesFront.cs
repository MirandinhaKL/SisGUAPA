using System.ComponentModel;

namespace SisGUAPA.UI.WPF.Uteis
{
    public class EnumeracoesFront
    {
        /// <summary>
        ///Texto (verbo conjugado) exibido ao usuário referente as operações CRUD dos dados.
        /// </summary>
        public enum MensagemCRUDTextoPassado
        {
            [Description("salvos")]
            Salvar = 1,
            [Description("editados")]
            Editar = 2,
            [Description("excluídos")]
            Excluir = 3
        }

        /// <summary>
        /// Texto (verbo infinitivo) exibido ao usuário referente as operações CRUD dos dados.
        /// </summary>
        public enum MensagemCRUDTextoVerbo
        {
            [Description("salvar")]
            Salvar = 1,
            [Description("editar")]
            Editar = 2,
            [Description("excluir")]
            Excluir = 3
        }

        public enum AcaoCRUD
        {
            Salvar = 1,
            Editar = 2,
            Excluir = 3
        }
    }
}