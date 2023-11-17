using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HawksMusic.API.Models;

namespace HawksMusic.API.Repositorios.Interface
{
    public interface IPlayListRepositorio
    {
        Task<List<PlayListModel>> ListarPlayLists();
        Task<PlayListModel> ListarPlayListsPorId(int Id);
        Task<PlayListModel> AtualizarPlayList(PlayListModel playListModel,int Id);
        Task<PlayListModel> CriarPlayList(PlayListModel playListModel);
        Task<bool> ApagarPlayList(PlayListModel playListModel,int Id);

    }
}