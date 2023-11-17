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
    public class AlbumController : ControllerBase
    {
       private readonly IAlbumRepositorio _AlbumRepositorio;

        public AlbumController(IAlbumRepositorio albumRepositorio)
        {
            _AlbumRepositorio = albumRepositorio;
        }
       [HttpPost()]
        public async Task<ActionResult<AlbumModel>> CriarAlbum([FromBody] AlbumModel AlbumModel)
        {
            return Ok(await _AlbumRepositorio.CriarAlbum(AlbumModel));
        }

        [HttpGet]
        public async Task<ActionResult<List<AlbumModel>>> ListarAlbums()
        {
            return Ok(await _AlbumRepositorio.ListaAlbums());
        }
        [HttpGet("{Id}")]
        public async Task<ActionResult<AlbumModel>> ListarAlbumsPorId(int Id)
        {
            return Ok(await _AlbumRepositorio.ListaAbumPorId(Id));
        }
    
        [HttpPut("{Id}")]
        public async Task<ActionResult<AlbumModel>> AtualizaAlbum([FromBody] AlbumModel AlbumModel,int Id)
        {
            return Ok(await _AlbumRepositorio.AtualizaAlbum(Id,AlbumModel));
        }
        [HttpDelete()]
        public async Task<ActionResult<AlbumModel>> ApagarAlbum([FromBody] AlbumModel AlbumModel,int Id)
        {
            return Ok(await _AlbumRepositorio.ApagaAlbum(Id,AlbumModel));
        }
    }
}