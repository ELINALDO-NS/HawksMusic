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

        [HttpGet]
        public async Task<ActionResult<List<AlbumModel>>> ListarAlbums()
        {
            return Ok(await _AlbumRepositorio.ListaAlbums());
        }
        [HttpGet("{Id}")]
        public async Task<ActionResult<AlbumModel>> ListarAlbums(int Id)
        {
            return Ok(await _AlbumRepositorio.ListaAbumPorId(Id));
        }
        [HttpPost()]
        public async Task<ActionResult<AlbumModel>> CadastrarAlbum([FromBody] AlbumModel AlbumModel)
        {
            return Ok(await _AlbumRepositorio.CadastrarAlbum(AlbumModel));
        }
        [HttpPut("{Id}")]
        public async Task<ActionResult<AlbumModel>> CadastrarAlbum([FromBody] AlbumModel AlbumModel,int Id)
        {
            return Ok(await _AlbumRepositorio.CadastrarAlbum(AlbumModel,Id));
        }
        [HttpPut("{Id}")]
        public async Task<ActionResult<AlbumModel>> ApagarAlbum([FromBody] AlbumModel AlbumModel,int Id)
        {
            return Ok(await _AlbumRepositorio.ApagarAlbum(AlbumModel,Id));
        }
    }
}