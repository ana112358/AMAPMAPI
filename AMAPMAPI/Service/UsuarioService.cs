using AMAPMAPI.Models;
using Microsoft.AspNetCore.Identity;

namespace AMAPMAPI.Service
{
    public class UsuarioService
    {
        // Lista de usuários usada como "banco de dados em memória" para teste
        // No lugar de um banco real, usamos uma lista para guardar objetos UsuarioModel
        private readonly List<UsuarioModel> _usuarios = new(); // simulação de banco

        private readonly PasswordHasher<UsuarioModel> _passwordHasher = new();

        public UsuarioModel CriarUsuario(string email, string senha)
        {

            if (_usuarios.Any(u => u.Email == email))
                throw new Exception("E-mail já cadastrado.");


            var novoUsuario = new UsuarioModel
            {
                Email = email,
            };

            novoUsuario.SenhaHash = _passwordHasher.HashPassword(novoUsuario, senha);
            _usuarios.Add(novoUsuario);
            return novoUsuario;
        }
    }
}
