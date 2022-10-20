using System;
using Projeto_CMTECH_UNICAP.Context;
using Projeto_CMTECH_UNICAP.Models;
using Microsoft.EntityFrameworkCore;

namespace Projeto_CMTECH_UNICAP.Services
{
    public class UsuariosService : IUsuarioService
    {
        private readonly AppDbContext _context;
        public UsuariosService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Usuario>> GetUsuarios()
        {
            try
            {
                return await _context.usuario.ToListAsync();
            }
            catch
            {

                throw;
            }
        }
        public async Task<IEnumerable<Usuario>> GetUsuariosByNome(string nome)
        {
            IEnumerable<Usuario> usuarios;
            if (!string.IsNullOrWhiteSpace(nome))
            {
                usuarios = await _context.usuario.Where(n => n.nome.Contains(nome)).ToListAsync();
            }
            else
            {
                usuarios = await GetUsuarios();
            }
            return usuarios;
        }
        public async Task<Usuario> GetUsuario(int id)
        {
            var usuario = await _context.usuario.FindAsync(id);
            return usuario;
        }
        public async Task CreateUsuario(Usuario usuario)
        {
            _context.usuario.Add(usuario);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateUsuario(Usuario usuario)
        {
            _context.Entry(usuario).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        public async Task DeleteUsuario(Usuario usuario)
        {
            _context.usuario.Remove(usuario);
            await _context.SaveChangesAsync();
        }

    }
}
