using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HawksMusic.API.Data;
using HawksMusic.API.Models;
using HawksMusic.API.Repositorios.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace HawksMusic.API.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly HawksDataContext _hawksDataContext;

        public UsuarioRepositorio(HawksDataContext hawksDataContext)
        {
            _hawksDataContext = hawksDataContext;
        }

        public async Task<bool> ApagarUsuario(int Id,UsuarioModel UsuarioModel)
        {

            UsuarioModel usuario = await UsusarioPorId(Id);
            if(usuario != null)
            {                    
              _hawksDataContext.Usuarios.Remove(UsuarioModel);
              await _hawksDataContext.SaveChangesAsync();
              return true;
            }
            else
            {
                throw new Exception($"usuario com Id {Id} Não encontrado !");
            }  
             
            
            
        }

        public async Task<UsuarioModel> AtualizarUsuario(int Id, UsuarioModel UsusarioModel)
        {
            UsuarioModel usuario = await UsusarioPorId(Id);
            if(usuario != null)
            {                    
                
                 usuario.Nome = UsusarioModel.Nome;
                 usuario.Email = UsusarioModel.Email;
                 usuario.Senha = UsusarioModel.Senha;
                 usuario.PlayListModelId = UsusarioModel.PlayListModelId;                    
                  _hawksDataContext.Usuarios.Update(usuario);
                  await _hawksDataContext.SaveChangesAsync();
                  return usuario;
            }
            else
            {
                throw new Exception($"usuario com Id {Id} Não encontrado !");
            }  
           

        }

        public async Task<UsuarioModel> CriarUsuario(UsuarioModel UsusarioModel)
        {
           UsuarioModel ususario = new UsuarioModel()
           {
                Nome = UsusarioModel.Nome,
               Email = UsusarioModel.Email,
               Senha = UsusarioModel.Senha,
               PlayListModelId = UsusarioModel.PlayListModelId

           } ;
           await _hawksDataContext.Usuarios.AddAsync(ususario);
           await _hawksDataContext.SaveChangesAsync();
           return ususario;
        }

        public async Task<List<UsuarioModel>> ListarUsusarios()
        {
          return  await _hawksDataContext.Usuarios.ToListAsync();
        }

        public async Task<UsuarioModel> UsusarioPorId(int Id)
        {
           return await _hawksDataContext.Usuarios.FirstOrDefaultAsync(x => x.Id == Id) ;

        }
    }
}