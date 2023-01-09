using MaterialDesignThemes.Wpf;
using SisGUAPA.Application.Services.Entidade;
using SisGUAPA.Domain.Entities;
using SisGUAPA.Infra.Data;
using SisGUAPA.UI.WPF.Uteis;
using SisGUAPA.UI.WPF.Windows.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace SisGUAPA.UI.WPF
{
    /// <summary>
    /// Lógica interna para CadastroEntidadeWindow.xaml
    /// </summary>
    public partial class CadastroEntidadeWindow : Window
    {
        private readonly IEntidadeService _entidadeService;
        private readonly SisGUAPAContext _dataBaseContext;

        private Dictionary<int, string> _tiposEntidade;

        public CadastroEntidadeWindow(IEntidadeService entidadeService, SisGUAPAContext dataBaseContext)
        {
            InitializeComponent();
            _entidadeService = entidadeService;
            _tiposEntidade = _entidadeService.GetTiposEntidade();
            _dataBaseContext = dataBaseContext;
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!pbSenha.Password.Equals(pbSenhaRepeticao.Password))
                {
                    var message = "A senha e a repetição da senha não coincidem.";
                    new RoutineMessage(message, MessageType.Error, MessageButtons.Ok).ShowDialog();
                }

                var entidade = new Entidade()
                {
                    DataCadastro = DateTime.Now,
                    Email = txtEmail.Text,
                    Nome = txtNome.Text,
                    Senha = pbSenha.Password,
                    TipoEntidade = cbTipoEntidade.SelectedIndex
                };

                var validator = _entidadeService.MandatoryFieldValidation(entidade);

                if (!validator.IsValid)
                {
                    var stringBuilder = new StringBuilder().Append("Não foi possível salvar os dados, pois:");
                    
                    foreach (var item in validator.Errors)
                    {
                        stringBuilder.Append($"- {item.ErrorMessage}\n");
                    }

                    new RoutineMessage(stringBuilder.ToString(), MessageType.Error, MessageButtons.Ok).ShowDialog();
                    return;
                }
                 
                var savedResult = _entidadeService.SaveEntidade(entidade);
                if (string.IsNullOrEmpty(savedResult))
                {
                    UtilFront.SuccessMessageCRUD(EnumerationsFront.MensagemCRUDTextoPassado.Salvar);
                    this.Close();
                }
                else
                {
                    UtilFront.FailMessageCRUD(EnumerationsFront.MensagemCRUDTextoVerbo.Salvar);
                    // TODO: salvar erro.
                }
            }
            catch (Exception ex)
            {
                // TODO: ver tratativas;
            }
           
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
