using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HawksMusic.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HawksMusic.API.Data.Map
{
    public class UsuarioPlayListMap : IEntityTypeConfiguration<UsuarioPlayList>
    {
        public void Configure(EntityTypeBuilder<UsuarioPlayList> builder)
        {
           builder.HasKey(x => x.Id);
           builder.Property(x => x.PlayListId);
           builder.HasOne(x => x.PlayList);
           builder.Property(x => x.UsuarioId);
           builder.HasOne(x => x.Usuario);
        }
    }
}