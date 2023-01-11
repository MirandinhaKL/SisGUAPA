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
public interface ILoginService
{
    public string LoginDataFilledUp(string email, string password);
    public GenericReturn LoginIsValid(string email, string password);
}