using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HawksMusic.API.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }                
        public string Nome { get; set; }                
        public string Email { get; set; }                
        public string Senha { get; set; } 
        public virtual ICollection<PlayListModel>? PlayList { get; set; }       
       
    }
}