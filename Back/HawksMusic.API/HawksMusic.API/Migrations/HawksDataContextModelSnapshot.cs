﻿// <auto-generated />
using System;
using HawksMusic.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HawksMusic.API.Migrations
{
    [DbContext(typeof(HawksDataContext))]
    partial class HawksDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.10");

            modelBuilder.Entity("HawksMusic.API.Models.AlbumModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AnoLancamento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Artista")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Gravadora")
                        .HasColumnType("TEXT");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Albums");
                });

            modelBuilder.Entity("HawksMusic.API.Models.MusicaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AlbumModelId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Arquivo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("PlayListModelId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AlbumModelId");

                    b.HasIndex("PlayListModelId");

                    b.ToTable("Musicas");
                });

            modelBuilder.Entity("HawksMusic.API.Models.PlayListModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("PlayLists");
                });

            modelBuilder.Entity("HawksMusic.API.Models.UsusarioModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("PlayListModelId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("PlayListModelId");

                    b.ToTable("Ususarios");
                });

            modelBuilder.Entity("HawksMusic.API.Models.MusicaModel", b =>
                {
                    b.HasOne("HawksMusic.API.Models.AlbumModel", "Album")
                        .WithMany()
                        .HasForeignKey("AlbumModelId");

                    b.HasOne("HawksMusic.API.Models.PlayListModel", null)
                        .WithMany("Musicas")
                        .HasForeignKey("PlayListModelId");

                    b.Navigation("Album");
                });

            modelBuilder.Entity("HawksMusic.API.Models.UsusarioModel", b =>
                {
                    b.HasOne("HawksMusic.API.Models.PlayListModel", "PlayList")
                        .WithMany()
                        .HasForeignKey("PlayListModelId");

                    b.Navigation("PlayList");
                });

            modelBuilder.Entity("HawksMusic.API.Models.PlayListModel", b =>
                {
                    b.Navigation("Musicas");
                });
#pragma warning restore 612, 618
        }
    }
}