using SisGUAPA.Application.Services.Entidade;
using SisGUAPA.Application.Util;
using SisGUAPA.Domain.Entities;
using SisGUAPA.Infra.Data;
using SisGUAPA.UI.WPF.Uteis;
using System;
using System.Collections.Generic;
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
                var entidade = new Entidade()
                {
                    DataCadastro = DateTime.Now,
                    Email = txtEmail.Text,
                    Nome = txtNome.Text,
                    Senha = pbSenha.Password,
                    TipoEntidade = cbTipoEntidade.SelectedIndex
                };

                if (!pbSenha.Password.Equals(pbSenhaRepeticao.Password))
                {
                    MessageBox.Show("A senha e a repetição não coincidem.");
                    return;
                }

                var validator = _entidadeService.ValidacaoCamposObrigatorios(entidade);
                if (validator.IsValid)
                {
                    if (_entidadeService.SalvarEntidade(entidade))
                    {
                        FuncoesGeraisFront.MensagemCRUDSucesso(EnumeracoesFront.AcaoCRUD.Salvar, EnumeracoesFront.MensagemCRUDTextoPassado.Salvar) ;
                        this.Close();
                    }
                    else
                    {
                        FuncoesGeraisFront.MensagemCRUDFalha(EnumeracoesFront.AcaoCRUD.Salvar, EnumeracoesFront.MensagemCRUDTextoVerbo.Salvar);
                        // TODO: salvar erro.
                    }
                }
                else
                {
                    var erros = validator.Errors;
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
