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

       public DbSet<UsusarioModel> Ususarios {get;set;}
       public DbSet<MusicaModel> Musicas {get;set;}
       public  DbSet<AlbumModel> Albums {get;set;}
       public DbSet<PlayListModel> PlayLists {get;set;}
    }
}