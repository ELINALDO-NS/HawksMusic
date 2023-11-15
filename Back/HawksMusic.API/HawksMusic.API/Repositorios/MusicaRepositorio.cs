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
    public class MusicaRepositorio : IMusicaRepositorio
    {
        private readonly HawksDataContext _hawksDataContext;

        public MusicaRepositorio(HawksDataContext hawksDataContext)
        {
            _hawksDataContext = hawksDataContext;
        }

        public async Task<bool> ApagaMusica(int Id, MusicaModel musicaModel)
        {
            MusicaModel musica = await ListaMusicaPorId(Id);
            if(musica != null)
            {   
                musica.Album = musicaModel.Album;
                musica.Arquivo = musicaModel.Arquivo;
                musica.Nome = musicaModel.Nome;
                 _hawksDataContext.Musicas.Remove(musica);
                 await _hawksDataContext.SaveChangesAsync();
                 return true;
            }
            else
            {
                throw new Exception($"Usuario Com Id {Id} Não encontrado !");
            }
          
        }

        public async Task<MusicaModel> AtualizaMusica(int Id, MusicaModel musicaModel)
        {
            MusicaModel musica = await ListaMusicaPorId(Id);
            if(musica != null)
            {
           
             musica.Nome = musicaModel.Nome;
             musica.Arquivo = musicaModel.Arquivo;
             musica.Album = musicaModel.Album;
             musica.AlbumModelId = musicaModel.AlbumModelId;
               _hawksDataContext.Musicas.Update(musica);
            await _hawksDataContext.SaveChangesAsync();
            return musica;
            
            }
            else
            {
                throw new Exception($"Usuario Com Id {Id} Não encontrado !");
            }
                 

          
        }

        public async Task<MusicaModel> ListaMusicaPorId(int Id)
        {
           return await _hawksDataContext.Musicas.FirstOrDefaultAsync(x=> x.Id == Id);
        }

        public async Task<List<MusicaModel>> ListaMusicas()
        {
            return await _hawksDataContext.Musicas.ToListAsync();
        }

        public async Task<MusicaModel> SalvaMusica(MusicaModel musicaModel)
        {
            await _hawksDataContext.Musicas.AddAsync(musicaModel);
            await _hawksDataContext.SaveChangesAsync();
            return musicaModel;
        }
    }
}