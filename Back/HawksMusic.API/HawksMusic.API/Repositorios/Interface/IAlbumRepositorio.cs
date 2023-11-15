using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HawksMusic.API.Models;

namespace HawksMusic.API.Repositorios.Interface
{
    public interface IAlbumRepositorio
    {
        Task<List<AlbumModel>> ListaAlbums();
        Task<AlbumModel> ListaAbumPorId(int Id);
        Task<AlbumModel> SalvaAlbum(AlbumModel albumModel);
        Task<AlbumModel> AtualizaAlbum(int Id,AlbumModel albumModel);
        Task<bool> ApagaAlbum(int Id,AlbumModel albumModel);

    }
}