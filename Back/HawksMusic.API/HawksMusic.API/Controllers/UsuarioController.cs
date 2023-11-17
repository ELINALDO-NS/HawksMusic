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
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public UsuarioController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        [HttpPost]
        public async Task<ActionResult<UsuarioModel>> CriarUsuaro([FromBody] UsuarioModel ususarioModel)
        {
            
            return Ok(await _usuarioRepositorio.CriarUsuario(ususarioModel));
        }
        [HttpGet]
        public async Task<ActionResult<List<UsuarioModel>>> ListaUsuarios()
        {
            
            return Ok(await _usuarioRepositorio.ListarUsusarios());
        }

         [HttpGet("{Id}")]
        public async Task<ActionResult<List<UsuarioModel>>> ListaUsuariosPorId(int Id)
        {
            UsuarioModel ususario = await _usuarioRepositorio.UsusarioPorId(Id);
            return Ok(ususario);
        }
        
       [HttpPut("{Id}")]
        public async Task<ActionResult<UsuarioModel>> AtualizaUsuario([FromBody] UsuarioModel ususarioModel, int Id)
        {

            return Ok(await _usuarioRepositorio.AtualizarUsuario(Id, ususarioModel));
            
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<bool>> ApagaUsuario([FromBody] UsuarioModel ususarioModel, int Id)
        {
            
            return Ok(await _usuarioRepositorio.ApagarUsuario(Id,ususarioModel));
        }
    }
}