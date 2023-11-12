using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HawksMusic.API.Models;
using Microsoft.EntityFrameworkCore;

namespace HawksMusic.API.Data
{
    public class HawksDataContext : DbContext
    {
        public HawksDataContext(DbContextOptions options) : base(options){}

        DbSet<UsusarioModel> Ususarios {get;set;}
        DbSet<MusicaModel> Musicas {get;set;}
        DbSet<AlbumModel> Albums {get;set;}
        DbSet<PlayListModel> PlayLists {get;set;}
    }
}