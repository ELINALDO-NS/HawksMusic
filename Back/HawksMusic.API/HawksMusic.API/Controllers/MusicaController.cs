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
    public class MusicaController : ControllerBase
    {
        public readonly IMusicaRepositorio _musicaRepositorio;
        
        public MusicaController(IMusicaRepositorio musicaRepositorio)
        {
            _musicaRepositorio = musicaRepositorio;
        }
        [HttpPost]
        public async Task<ActionResult<MusicaModel>> SalvarMusica([FromBody] MusicaModel musicaModel)
        {
           
            return Ok(await _musicaRepositorio.CriarMusica(musicaModel));
        }
        [HttpGet]
        public async Task<ActionResult<List<MusicaModel>>> ListarMusicas()
        {
            return Ok(await _musicaRepositorio.ListaMusicas());
        }
        [HttpGet("{Id}")]
        public async Task<ActionResult<MusicaModel>> ListaMusicaPorId(int Id)
        {
            return Ok(await _musicaRepositorio.ListaMusicaPorId(Id));
        }
         [HttpPut]
        public async Task<ActionResult<MusicaModel>> AtualizaMusica([FromBody] MusicaModel musicaModel, int Id)
        {
            return Ok(await _musicaRepositorio.AtualizaMusica(Id,musicaModel));
        }
        [HttpDelete("{Id}")]
        public async Task<ActionResult<MusicaModel>> ApagarMusica([FromBody] MusicaModel musicaModel, int Id)
        {
            return Ok(await _musicaRepositorio.ApagaMusica(Id,musicaModel));
        }

    }
}