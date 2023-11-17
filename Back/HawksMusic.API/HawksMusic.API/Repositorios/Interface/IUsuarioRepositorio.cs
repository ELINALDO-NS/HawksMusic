using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HawksMusic.API.Models;

namespace HawksMusic.API.Repositorios.Interface
{
    public interface IUsuarioRepositorio
    {
        Task<UsuarioModel> CriarUsuario(UsuarioModel UsuarioModel);
        Task<List<UsuarioModel>> ListarUsusarios();
        Task<UsuarioModel> UsusarioPorId(int Id);
        Task<UsuarioModel> AtualizarUsuario(int Id,UsuarioModel UsuarioModel);
        Task<bool> ApagarUsuario(int Id,UsuarioModel UsuarioModel);
        


    }
}