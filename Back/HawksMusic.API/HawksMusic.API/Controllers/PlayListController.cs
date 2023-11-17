using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HawksMusic.API.Models;
using HawksMusic.API.Repositorios.Interface;
using Microsoft.AspNetCore.Mvc;

namespace HawksMusic.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlayListController : ControllerBase
    {
        private readonly IPlayListRepositorio _playListRepositorio;

        public PlayListController(IPlayListRepositorio playListRepositorio)
        {
            _playListRepositorio = playListRepositorio;
        }
        [HttpPost]
        public async Task<ActionResult<PlayListModel>> CriarPlayList(PlayListModel playListModel)
        {
            return Ok(await _playListRepositorio.CriarPlayList(playListModel));
        }
        [HttpGet]
        public async Task<ActionResult<List<PlayListModel>>> ListarPlayList()
        {
            return Ok(await _playListRepositorio.ListarPlayLists());
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<PlayListModel>> ListarPlayListPorId(int Id)
        {
            return Ok(await _playListRepositorio.ListarPlayListsPorId(Id));
        }
        [HttpPut("{Id}")]
        public async Task<ActionResult<PlayListModel>> AtualizarPlayList([FromBody] PlayListModel playListModel,int Id)
        {
            return Ok(await _playListRepositorio.AtualizarPlayList(playListModel, Id));
        }
        [HttpDelete()]
        public async Task<ActionResult<PlayListModel>> ApagarPlayList([FromBody] PlayListModel playListModel,int Id)
        {
            return Ok(await _playListRepositorio.ApagarPlayList(playListModel, Id));
        }
    }
}