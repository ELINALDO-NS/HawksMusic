using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HawksMusic.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HawksMusic.API.Data.Map
{
    public class UsuarioMap : IEntityTypeConfiguration<UsusarioModel>
    {
        public void Configure(EntityTypeBuilder<UsusarioModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Senha).IsRequired().HasMaxLength(255);
            builder.Property(x =>x.PlayListModelId);
            builder.HasOne(x => x.PlayList);
        }
    }
}