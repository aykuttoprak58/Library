using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DBFirstLibrary.Models
{
    public partial class db_libraryContext : DbContext
    {
        public db_libraryContext()
        {
        }

        public db_libraryContext(DbContextOptions<db_libraryContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Eserler> Eserlers { get; set; } = null!;
        public virtual DbSet<Kategoriler> Kategorilers { get; set; } = null!;
        public virtual DbSet<Yazarlar> Yazarlars { get; set; } = null!;
        public virtual DbSet<Ülkeler> Ülkelers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server= HPISNET;Database=db_library;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Eserler>(entity =>
            {
                entity.HasKey(e => e.EserId)
                    .HasName("PK__eserler__28E7CBAF67E7110E");

                entity.ToTable("eserler");

                entity.Property(e => e.EserId).HasColumnName("eserId");

                entity.Property(e => e.EserAdi)
                    .HasMaxLength(30)
                    .HasColumnName("eserAdi");

                entity.Property(e => e.Kategori).HasColumnName("kategori");

                entity.Property(e => e.YayinTarihi).HasColumnName("yayinTarihi");

                entity.Property(e => e.Yazar).HasColumnName("yazar");
            });

            modelBuilder.Entity<Kategoriler>(entity =>
            {
                entity.HasKey(e => e.KategoriId)
                    .HasName("PK__kategori__1D91819D44073034");

                entity.ToTable("kategoriler");

                entity.Property(e => e.KategoriId).HasColumnName("kategoriId");

                entity.Property(e => e.KategoriAdi)
                    .HasMaxLength(30)
                    .HasColumnName("kategoriAdi");
            });

            modelBuilder.Entity<Yazarlar>(entity =>
            {
                entity.HasKey(e => e.YazarId)
                    .HasName("PK__yazarlar__CCD01A3A6F24D619");

                entity.ToTable("yazarlar");

                entity.Property(e => e.YazarId).HasColumnName("yazarId");

                entity.Property(e => e.YazarAdi)
                    .HasMaxLength(30)
                    .HasColumnName("yazarAdi");

                entity.Property(e => e.YazarUlkesi).HasColumnName("yazarUlkesi");

                entity.Property(e => e.YazarYasi).HasColumnName("yazarYasi");
            });

            modelBuilder.Entity<Ülkeler>(entity =>
            {
                entity.HasKey(e => e.UlkeId)
                    .HasName("PK__ülkeler__B0FE7E2E476A3D90");

                entity.ToTable("ülkeler");

                entity.Property(e => e.UlkeId).HasColumnName("ulkeId");

                entity.Property(e => e.UlkeAdi)
                    .HasMaxLength(30)
                    .HasColumnName("ulkeAdi");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
