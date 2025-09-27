namespace AMAPMAPI.Models;
public class DadosUsuarioModel
{
    public int Id { get; set; }
    public int UsuarioId { get; set; } 
    public string Nome { get; set; } = string.Empty;
    public DateTime DataNascimento { get; set; }
    public EnderecoModel Endereco { get; set; } = new EnderecoModel();
    public List<AtividadeModel> Atividades { get; set; } = new List<AtividadeModel>();
    public string TipoUsuario { get; set; } = string.Empty;
}
public class EnderecoModel
{
    public string Logradouro { get; set; } = string.Empty;
    public string Numero { get; set; } = string.Empty;
    public string Complemento { get; set; } = string.Empty;
    public string Bairro { get; set; } = string.Empty;
    public string Cidade { get; set; } = string.Empty;
    public string Estado { get; set; } = string.Empty;
    public string CEP { get; set; } = string.Empty;
}
public class AtividadeModel
{
    public int Id { get; set; }               
    public string Descricao { get; set; } = string.Empty; 
    public DateTime Data { get; set; } = DateTime.Now; 
}

