using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HawksMusic.API.Models;

namespace HawksMusic.API.Repositorios.Interface
{
    public interface IUsuarioRepositorio
    {
        Task<UsusarioModel> CriarUsuario(UsusarioModel UsusarioModel);
        Task<List<UsusarioModel>> ListarUsusarios();
        Task<UsusarioModel> UsusarioPorId(int Id);
        Task<UsusarioModel> AtualizarUsuario(int Id,UsusarioModel UsusarioModel);
        Task<bool> ApagarUsuario(int Id,UsusarioModel UsusarioModel);
        


    }
}