using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HawksMusic.API.Models
{
    public class MusicaModel
    {
         public int Id { get; set; } 
       public string  Nome { get; set; }
       public string  Arquivo { get; set; }
       public int? AlbumModelId { get; set; }
       public virtual  AlbumModel? Album { get; set; }
    }
}