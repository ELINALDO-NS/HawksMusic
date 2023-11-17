using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HawksMusic.API.Models;

namespace HawksMusic.API.Repositorios.Interface
{
    public interface IMusicaRepositorio
    {
        Task<MusicaModel> CriarMusica(MusicaModel musicaModel);
        Task<List<MusicaModel>> ListaMusicas();
        Task<MusicaModel> ListaMusicaPorId(int Id);
        Task<MusicaModel> AtualizaMusica(int Id,MusicaModel musicaModel);
        Task<bool> ApagaMusica(int Id,MusicaModel musicaModel);



    }
}