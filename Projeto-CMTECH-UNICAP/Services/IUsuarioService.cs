using Projeto_CMTECH_UNICAP.Models;

namespace Projeto_CMTECH_UNICAP.Services

{
    public interface IUsuarioService
    {
        Task<IEnumerable<Usuario>> GetUsuarios();
        Task<Usuario> GetUsuario(int id);
        Task<IEnumerable<Usuario>> GetUsuariosByNome(string nome);
        Task CreateUsuario(Usuario usuario);
        Task UpdateUsuario(Usuario usuario);
        Task DeleteUsuario(Usuario usuario);
    }
}
