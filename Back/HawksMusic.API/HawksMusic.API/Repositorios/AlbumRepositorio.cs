using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HawksMusic.API.Data;
using HawksMusic.API.Models;
using Microsoft.EntityFrameworkCore;

namespace HawksMusic.API.Repositorios
{
    public class AlbumRepositorio : IAlbumRepositorio
    {
        private readonly HawksDataContext _hawksMusic;

        public AlbumRepositorio(HawksDataContext hawksMusic)
        {
            _hawksMusic = hawksMusic;
        }

        public async Task<bool> ApagaAlbum(int Id, AlbumModel albumModel)
        {
             AlbumModel album = await ListaAbumPorId(Id);
            if(album != null)
            { 
                 _hawksMusic.Albums.Remove(album);
                await _hawksMusic.SaveChangesAsync();
                return true;

            }
            else
            {
                throw new Exception($"Album por Id {Id} Não encontrado");
            }
        }

        public async Task<AlbumModel> AtualizaAlbum(int Id, AlbumModel albumModel)
        {
            AlbumModel album = await ListaAbumPorId(Id);
            if(album != null)
            {
                album.Artista = albumModel.Artista;
                album.Titulo = albumModel.Titulo;
                album.AnoLancamento = albumModel.AnoLancamento;
                album.Gravadora = albumModel.AnoLancamento;
                 _hawksMusic.Albums.Update(album);
                await _hawksMusic.SaveChangesAsync();
                return album;

            }
            else
            {
                throw new Exception($"Album por Id {Id} Não encontrado");
            }

           
        }

        public async Task<AlbumModel> ListaAbumPorId(int Id)
        {

           return await _hawksMusic.Albums.FirstOrDefaultAsync(x => x.Id == Id);
        }

        public async Task<List<AlbumModel>> ListaAlbums()
        {
            return await _hawksMusic.Albums.ToListAsync();
        }

        public async Task<AlbumModel> SalvaAlbum(AlbumModel albumModel)
        {
           await _hawksMusic.Albums.AddAsync(albumModel);
          await  _hawksMusic.SaveChangesAsync();
            return albumModel;
        }
    }
}