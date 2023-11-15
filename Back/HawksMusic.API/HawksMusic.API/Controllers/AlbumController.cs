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
    }
}