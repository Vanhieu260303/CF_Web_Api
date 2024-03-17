using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Drawing;

namespace CF_Web_Api.Data
{
    public class DataContext : IdentityDbContext<ApplicationUser>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DataContext(){}


        public virtual DbSet<Account> Accounts { get; set; } 
        public virtual DbSet<Blocks> Blocks { get; set; } 
        public virtual DbSet<Ca> Cas { get; set; } 
        public virtual DbSet<Campus> Campuses { get; set; } 
        public virtual DbSet<DanhGia> DanhGia { get; set; } 
        public virtual DbSet<Floors> Floors { get; set; } 
        public virtual DbSet<FormDanhGia> FormDanhGia { get; set; } 
        public virtual DbSet<ReportAuthorize> ReportAuthorizes { get; set; } 
        public virtual DbSet<ReportDanhGia> ReportDanhGia { get; set; } 
        public virtual DbSet<Rooms> Rooms { get; set; }
        public virtual DbSet<RoomsCategory> RoomCategories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Define the keys for IdentityUserLogin<string> entity
            modelBuilder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });
            });
            modelBuilder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });
            });
            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("Account");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.HoTen).HasMaxLength(20);

                entity.Property(e => e.Pass).HasColumnType("text");

                entity.Property(e => e.UpdateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Blocks>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.BlockCode).HasMaxLength(50);

                entity.Property(e => e.BlockName).HasMaxLength(50);

                entity.Property(e => e.CreateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateTime).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Campus)
                    .WithMany(p => p.Blocks)
                    .HasForeignKey(d => d.CampusId)
                    .HasConstraintName("FK__Blocks__CampusId__3D5E1FD2");
            });

            modelBuilder.Entity<Ca>(entity =>
            {
                entity.ToTable("Ca");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TenCa).HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Campus>(entity =>
            {
                entity.ToTable("Campus");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CampusCode).HasMaxLength(50);

                entity.Property(e => e.CampusName).HasMaxLength(50);

                entity.Property(e => e.CampusSymbol)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CreateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DanhGia>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TenNoiDungDanhGia).HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Floors>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FloorCode).HasMaxLength(50);

                entity.Property(e => e.FloorName).HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Block)
                    .WithMany(p => p.Floors)
                    .HasForeignKey(d => d.BlockId)
                    .HasConstraintName("FK__Floors__BlockId__4316F928");
            });

            modelBuilder.Entity<FormDanhGia>(entity =>
            {
                entity.ToTable("formDanhGia");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateTime).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.IdCaNavigation)
                    .WithMany(p => p.FormDanhGia)
                    .HasForeignKey(d => d.IdCa)
                    .HasConstraintName("FK__formDanhGi__IdCa__6383C8BA");

                entity.HasOne(d => d.IdRoomNavigation)
                    .WithMany(p => p.FormDanhGia)
                    .HasForeignKey(d => d.IdRoom)
                    .HasConstraintName("FK__formDanhG__IdRoo__628FA481");
            });

            modelBuilder.Entity<ReportAuthorize>(entity =>
            {
                entity.HasKey(e => new { e.IdForm, e.IdDanhGia });

                entity.ToTable("reportAuthorize");

                entity.Property(e => e.CreateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDelete).HasColumnName("isDelete");

                entity.Property(e => e.UpdateTime).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.IdDanhGiaNavigation)
                    .WithMany(p => p.ReportAuthorizes)
                    .HasForeignKey(d => d.IdDanhGia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__reportAut__IdDan__693CA210");

                entity.HasOne(d => d.IdFormNavigation)
                    .WithMany(p => p.ReportAuthorizes)
                    .HasForeignKey(d => d.IdForm)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__reportAut__IdFor__68487DD7");
            });

            modelBuilder.Entity<ReportDanhGia>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FormDanhGiaId).HasColumnName("formDanhGiaId");

                entity.Property(e => e.GhiChu).HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.ReportDanhGia)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK__ReportDan__Accou__6FE99F9F");

                entity.HasOne(d => d.FormDanhGia)
                    .WithMany(p => p.ReportDanhGia)
                    .HasForeignKey(d => d.FormDanhGiaId)
                    .HasConstraintName("FK__ReportDan__formD__6EF57B66");
            });

            modelBuilder.Entity<Rooms>(entity =>
            {
                entity.ToTable("Room");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RoomCode).HasMaxLength(50);

                entity.Property(e => e.RoomName).HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Floors)
                    .WithMany(p => p.Rooms)
                    .HasForeignKey(d => d.FloorsId)
                    .HasConstraintName("FK__Room__FloorsId__4E88ABD4");

                entity.HasOne(d => d.IdCateNavigation)
                    .WithMany(p => p.Rooms)
                    .HasForeignKey(d => d.IdCate)
                    .HasConstraintName("FK__Room__IdCate__4D94879B");
            });

            modelBuilder.Entity<RoomsCategory>(entity =>
            {
                entity.ToTable("roomCategory");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CategoryCode).HasMaxLength(50);

                entity.Property(e => e.CategoryName).HasMaxLength(50);

                entity.Property(e => e.CreateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateTime).HasDefaultValueSql("(getdate())");
            });

            
        }

        


    }
}
