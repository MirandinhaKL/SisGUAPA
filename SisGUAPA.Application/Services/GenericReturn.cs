using System.Collections.Generic;

namespace SisGUAPA.Application.Services;

/// <summary>
/// Iniciado em: 10/01/23
/// </summary>
public class GenericReturn
{
    public bool Success { get; set; }

    public List<string> Errors { get; set; }
}