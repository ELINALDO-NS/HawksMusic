using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HawksMusic.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HawksMusic.API.Data.Map{

public class PlayListMap : IEntityTypeConfiguration<PlayListModel>
{
    public void Configure(EntityTypeBuilder<PlayListModel> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Nome).IsRequired().HasMaxLength(30);
        //builder.Property(x => x.Musicas).IsRequired().HasMaxLength(30);
    }
}
}