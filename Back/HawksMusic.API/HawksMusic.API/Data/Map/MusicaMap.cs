using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HawksMusic.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HawksMusic.API.Data.Map
{
    public class MusicaMap : IEntityTypeConfiguration<MusicaModel>
    {
        public void Configure(EntityTypeBuilder<MusicaModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Arquivo).IsRequired().HasMaxLength(255);
            builder.Property(x => x.AlbumModelId);;
            builder.HasOne(x => x.Album);
        }
    }
}