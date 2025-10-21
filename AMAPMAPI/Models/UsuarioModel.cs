using System.ComponentModel.DataAnnotations;

namespace AMAPMAPI.Models;

public class UsuarioModel
{
    public int Id { get; set; }
    public string Email { get; set; } = string.Empty;
    public string SenhaHash { get; set; } = string.Empty; 
    public DateTime DataCriacao { get; set; } = DateTime.UtcNow;
}

