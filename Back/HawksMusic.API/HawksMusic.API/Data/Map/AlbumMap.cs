using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HawksMusic.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HawksMusic.API.Data.Map
{
    public class AlbumMap : IEntityTypeConfiguration<AlbumModel>
    {
        public void Configure(EntityTypeBuilder<AlbumModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Titulo).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Artista).IsRequired().HasMaxLength(50);
            builder.Property(x => x.AnoLancamento).HasMaxLength(50);
            builder.Property(x => x.Gravadora).HasMaxLength(50);
            
        }
    }
}