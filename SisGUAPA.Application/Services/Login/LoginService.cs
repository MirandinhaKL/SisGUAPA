using SisGUAPA.Infra.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisGUAPA.Application.Services.Login;

/// <summary>
/// Iniciado em: 09/01/23
/// </summary>
public class LoginService : BaseService<LoginService>, ILoginService
{
    private readonly SisGUAPAContext _dataBaseContext;

    public LoginService(SisGUAPAContext dataBaseContext) : base (dataBaseContext)
    {
        _dataBaseContext = dataBaseContext;
    }

    public string LoginDataFilledUp(string email, string password)
    {
        if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            return "O e-mail e a senha devem ser informados.";
        
        return string.Empty;
    }

    public GenericReturn LoginIsValid(string email, string password)
    {
        var validData = LoginDataFilledUp(email, password);
        if (!string.IsNullOrEmpty(validData))
            return new GenericReturn() { Success = false, Errors = new List<string>() { validData } };

        return null;

    }
}
