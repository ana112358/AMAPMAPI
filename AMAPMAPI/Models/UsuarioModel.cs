namespace AMAPMAPI.Models;

public class UsuarioModel
{
    public int ID { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }
    public DateTime DataCriacao { get; set; } = DateTime.MinValue;
}

