using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HawksMusic.API.Models
{
    public class UsuarioPlayList
    {
        public int Id { get; set; } 
        public int? UsuarioId { get; set; }   
        public virtual UsuarioModel? Usuario { get; set; }        
        public int? PlayListId { get; set; }   
        public virtual PlayListModel? PlayList { get; set; }
    }
}