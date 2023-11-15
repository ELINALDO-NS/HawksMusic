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
           _hawksDataContext.Musicas.Remove(musicaModel);
           await _hawksDataContext.SaveChangesAsync();
           return true;
        }

        public async Task<MusicaModel> AtualizaMusica(int Id, MusicaModel musicaModel)
        {
            MusicaModel Musica = new MusicaModel()
            {Id = musicaModel.Id,
             Nome = musicaModel.Nome,
             Arquivo = musicaModel.Arquivo,
             Album = musicaModel.Album,
             AlbumModelId = musicaModel.AlbumModelId
            };
            _hawksDataContext.Musicas.Update(Musica);
            await _hawksDataContext.SaveChangesAsync();
            return Musica;
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