using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HawksMusic.API.Data.Map;
using HawksMusic.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace HawksMusic.API.Data
{
    public class HawksDataContext : DbContext
    {
        public HawksDataContext(DbContextOptions options) : base(options){}

       public DbSet<UsusarioModel> Ususarios {get;set;}
       public DbSet<MusicaModel> Musicas {get;set;}
       public  DbSet<AlbumModel> Albums {get;set;}
       public DbSet<PlayListModel> PlayLists {get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new MusicaMap());
            modelBuilder.ApplyConfiguration(new AlbumMap());
            modelBuilder.ApplyConfiguration(new PlayListMap());
            base.OnModelCreating(modelBuilder);
        }

    }
}
