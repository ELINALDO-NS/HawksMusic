using HawksMusic.API.Data;
using HawksMusic.API.Models;
using HawksMusic.API.Repositorios.Interface;
using Microsoft.EntityFrameworkCore;

namespace HawksMusic.API;

public class PlayListRepositorio : IPlayListRepositorio
{
    private readonly HawksDataContext _hawksDataContext;

    public PlayListRepositorio(HawksDataContext hawksDataContext)
    {
        _hawksDataContext = hawksDataContext;
    }

    public async Task<bool> ApagarPlayList(PlayListModel playListModel, int Id)
    {
        PlayListModel playList = await ListarPlayListsPorId(Id);
        if(playList != null)
        {
            _hawksDataContext.PlayLists.Remove(playListModel);
            await _hawksDataContext.SaveChangesAsync();
            return true;
        }
        else
        {
            throw new Exception($"PlayList por Id{Id} Não Encontrado !");
        }
    }

    public async Task<PlayListModel> AtualizarPlayList(PlayListModel playListModel, int Id)
    {
        PlayListModel playList = await ListarPlayListsPorId(Id);
        if(playList != null)
        {
            playList.MusicaId = playListModel.MusicaId;
            playList.Nome = playListModel.Nome;
             _hawksDataContext.Update(playList);
             await _hawksDataContext.SaveChangesAsync();
             return playList;

        }
        else
        {
            throw new Exception($"PlayList por Id{Id} Não Encontrado !");
        }


    }

    public async Task<PlayListModel> CriarPlayList(PlayListModel playListModel)
    {
        await _hawksDataContext.PlayLists.AddAsync(playListModel);
        await _hawksDataContext.SaveChangesAsync();
        return playListModel;
    }

    public async Task<List<PlayListModel>> ListarPlayLists()
    {
        return await _hawksDataContext.PlayLists.ToListAsync();
    }

    public async Task<PlayListModel> ListarPlayListsPorId(int Id)
    {
        PlayListModel playList =  await _hawksDataContext.PlayLists.FirstOrDefaultAsync(x => x.Id == Id);
        if(playList != null)
        {
             return playList;
        }
        else
        {
            throw new Exception($"PlayList por Id{Id} Não Encontrado !");
        }
      
    }
}
