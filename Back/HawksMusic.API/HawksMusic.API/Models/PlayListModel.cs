using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HawksMusic.API.Models
{
    public class PlayListModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<MusicaModel> Musicas { get; set; }

    }
}