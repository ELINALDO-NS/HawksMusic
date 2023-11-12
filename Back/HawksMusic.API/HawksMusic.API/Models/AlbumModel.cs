using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HawksMusic.API.Models
{
    public class AlbumModel
    {
         public int Id { get; set; }
        public string Titulo { get; set; }
        public string Artista { get; set; }
        public string? AnoLancamento { get; set; }
        public string? Gravadora { get; set; }
    }
}