﻿// <auto-generated />
using System;
using CDFirstLibrary.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CDFirstLibrary.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CDFirstLibrary.Models.Eserler", b =>
                {
                    b.Property<int>("EserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EserId"), 1L, 1);

                    b.Property<string>("EserAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Kategori")
                        .HasColumnType("int");

                    b.Property<int?>("YayinTarihi")
                        .HasColumnType("int");

                    b.Property<int?>("Yazar")
                        .HasColumnType("int");

                    b.HasKey("EserId");

                    b.ToTable("eserler");
                });

            modelBuilder.Entity("CDFirstLibrary.Models.Kategoriler", b =>
                {
                    b.Property<int>("KategoriId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KategoriId"), 1L, 1);

                    b.Property<string>("KategoriAdi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KategoriId");

                    b.ToTable("kategoriler");
                });

            modelBuilder.Entity("CDFirstLibrary.Models.Ülkeler", b =>
                {
                    b.Property<int>("UlkeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UlkeId"), 1L, 1);

                    b.Property<string>("UlkeAdi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UlkeId");

                    b.ToTable("ülkeler");
                });

            modelBuilder.Entity("CDFirstLibrary.Models.Yazarlar", b =>
                {
                    b.Property<int>("YazarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("YazarId"), 1L, 1);

                    b.Property<string>("YazarAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("YazarUlkesi")
                        .HasColumnType("int");

                    b.Property<int?>("YazarYasi")
                        .HasColumnType("int");

                    b.HasKey("YazarId");

                    b.ToTable("yazarlar");
                });
#pragma warning restore 612, 618
        }
    }
}
