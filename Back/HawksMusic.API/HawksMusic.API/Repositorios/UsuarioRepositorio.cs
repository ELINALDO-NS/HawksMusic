using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HawksMusic.API.Data;
using HawksMusic.API.Models;
using HawksMusic.API.Repositorios.Interface;
using Microsoft.EntityFrameworkCore;

namespace HawksMusic.API.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly HawksDataContext _hawksDataContext;

        public UsuarioRepositorio(HawksDataContext hawksDataContext)
        {
            _hawksDataContext = hawksDataContext;
        }

        public async Task<bool> ApagarUsuario(int Id,UsusarioModel UsusarioModel)
        {

               
              _hawksDataContext.Ususarios.Remove(UsusarioModel);
              await _hawksDataContext.SaveChangesAsync();
              return true;
            
            
        }

        public async Task<UsusarioModel> AtualizarUsuario(int Id, UsusarioModel UsusarioModel)
        {

                UsusarioModel ususario = new UsusarioModel()
               { Id = UsusarioModel.Id,
                 Nome = UsusarioModel.Nome,
                Email = UsusarioModel.Email,
                Senha = UsusarioModel.Senha,
                PlayList = UsusarioModel.PlayList

               } ;

              _hawksDataContext.Ususarios.Update(UsusarioModel);
              await _hawksDataContext.SaveChangesAsync();
              return ususario;
          
         
        }

        public async Task<UsusarioModel> CriarUsuario(UsusarioModel UsusarioModel)
        {
           UsusarioModel ususario = new UsusarioModel()
           {
                Nome = UsusarioModel.Nome,
               Email = UsusarioModel.Email,
               Senha = UsusarioModel.Senha,
               PlayList = UsusarioModel.PlayList

           } ;
           await _hawksDataContext.Ususarios.AddAsync(ususario);
           await _hawksDataContext.SaveChangesAsync();
           return ususario;
        }

        public async Task<List<UsusarioModel>> ListarUsusarios()
        {
          return  await _hawksDataContext.Ususarios.ToListAsync();
        }

        public async Task<UsusarioModel> UsusarioPorId(int Id)
        {
           return await _hawksDataContext.Ususarios.FirstOrDefaultAsync(x => x.Id == Id) ;

        }
    }
}