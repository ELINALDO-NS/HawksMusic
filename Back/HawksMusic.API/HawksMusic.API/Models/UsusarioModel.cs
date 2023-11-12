using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HawksMusic.API.Models
{
    public class UsusarioModel
    {
        public int Id { get; set; }                
        public string Nome { get; set; }                
        public string Email { get; set; }                
        public string Senha { get; set; } 
        public int? PlayListModelId { get; set; }           
        public virtual PlayListModel? PlayList { get; set; }           
    }
}