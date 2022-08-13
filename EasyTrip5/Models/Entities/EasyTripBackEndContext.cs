using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EasyTrip5.Models.Entities
{
    public partial class EasyTripBackEndContext : DbContext
    {
        public EasyTripBackEndContext()
        {
        }

        public EasyTripBackEndContext(DbContextOptions<EasyTripBackEndContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<AdresBlog> AdresBlogs { get; set; }
        public virtual DbSet<AnaSayfa> AnaSayfas { get; set; }
        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<Hakkımızda> Hakkımızdas { get; set; }
        public virtual DbSet<Iletisim> Iletisims { get; set; }
        public virtual DbSet<Yorumlar> Yorumlars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //'Server=(localdb)\MSSQLLocalDB;Database=EasyTripBackEnd;Trusted_Connection=True;User Id=DESKTOP-UBHIB7K\YILDIRAY;' Microsoft.EntityFrameworkCore.SqlServer - OutputDir Models / Entities

                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=EasyTripBackEnd;Trusted_Connection=True;User Id=DESKTOP-UBHIB7K\\YILDIRAY;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Admin>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Kullanici)
                    .HasMaxLength(50)
                    .HasColumnName("KULLANICI");

                entity.Property(e => e.Sifre)
                    .HasMaxLength(50)
                    .HasColumnName("SIFRE");
            });

            modelBuilder.Entity<AdresBlog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Aciklama).HasColumnName("ACIKLAMA");

                entity.Property(e => e.Adresacik).HasColumnName("ADRESACIK");

                entity.Property(e => e.Baslik).HasColumnName("BASLIK");

                entity.Property(e => e.Konum).HasColumnName("KONUM");

                entity.Property(e => e.Mail)
                    .HasMaxLength(100)
                    .HasColumnName("MAIL");

                entity.Property(e => e.Telefon)
                    .HasMaxLength(50)
                    .HasColumnName("TELEFON");
            });

            modelBuilder.Entity<AnaSayfa>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Aciklama).HasColumnName("ACIKLAMA");

                entity.Property(e => e.Baslik).HasColumnName("BASLIK");
            });

            modelBuilder.Entity<Blog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Aciklama).HasColumnName("ACIKLAMA");

                entity.Property(e => e.Baslik).HasColumnName("BASLIK");

                entity.Property(e => e.Blogimage).HasColumnName("BLOGIMAGE");

                entity.Property(e => e.Tarih)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("TARIH");
            });

            modelBuilder.Entity<Hakkımızda>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Aciklama).HasColumnName("ACIKLAMA");

                entity.Property(e => e.Fotourl).HasColumnName("FOTOURL");
            });

            modelBuilder.Entity<Iletisim>(entity =>
            {
                entity.ToTable("iletisims");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Adsoyad).HasColumnName("ADSOYAD");

                entity.Property(e => e.Konu).HasColumnName("KONU");

                entity.Property(e => e.Mail).HasColumnName("MAIL");

                entity.Property(e => e.Mesaj).HasColumnName("MESAJ");
            });

            modelBuilder.Entity<Yorumlar>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Kullaniciadi).HasColumnName("KULLANICIADI");

                entity.Property(e => e.Mail).HasColumnName("MAIL");

                entity.Property(e => e.Yorum).HasColumnName("YORUM");

                entity.HasOne(d => d.BlogsNavigation)
                    .WithMany(p => p.Yorumlars)
                    .HasForeignKey(d => d.Blogs)
                    .HasConstraintName("FK_Yorumlars_Blogs");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
