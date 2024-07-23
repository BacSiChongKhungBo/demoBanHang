using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using demoBanHang.DomainClass;

namespace demoBanHang.Context;

public partial class DBContext : DbContext
{
    public DBContext()
    {
    }

    public DBContext(DbContextOptions<DBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cthd> Cthds { get; set; }

    public virtual DbSet<Ctsp> Ctsps { get; set; }

    public virtual DbSet<Hang> Hangs { get; set; }

    public virtual DbSet<Hoadon> Hoadons { get; set; }

    public virtual DbSet<SanPham> SanPhams { get; set; }

    public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }

    public virtual DbSet<TheTich> TheTiches { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source= DESKTOP-GAT3RNS\\SQLEXPRESS ;Initial Catalog= DEMOXUONG;Integrated Security=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cthd>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CTHD__3213E83FDCF149AF");

            entity.HasOne(d => d.IdCtspNavigation).WithMany(p => p.Cthds).HasConstraintName("FK__CTHD__idCTSP__47DBAE45");

            entity.HasOne(d => d.IdHdNavigation).WithMany(p => p.Cthds).HasConstraintName("FK__CTHD__idHD__46E78A0C");
        });

        modelBuilder.Entity<Ctsp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CTSP__3213E83FE9FC9F1A");

            entity.HasOne(d => d.IdHangNavigation).WithMany(p => p.Ctsps).HasConstraintName("FK__CTSP__idHang__403A8C7D");

            entity.HasOne(d => d.IdSpNavigation).WithMany(p => p.Ctsps).HasConstraintName("FK__CTSP__TrangThai__3F466844");

            entity.HasOne(d => d.IdTheTichNavigation).WithMany(p => p.Ctsps).HasConstraintName("FK__CTSP__idTheTich__412EB0B6");
        });

        modelBuilder.Entity<Hang>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Hang__3213E83FB4C8AA0B");
        });

        modelBuilder.Entity<Hoadon>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__HOADON__3213E83F6E58EB76");

            entity.HasOne(d => d.IdNvNavigation).WithMany(p => p.Hoadons).HasConstraintName("FK__HOADON__idNV__440B1D61");
        });

        modelBuilder.Entity<SanPham>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SanPham__3213E83F0680F8E7");
        });

        modelBuilder.Entity<TaiKhoan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TaiKhoan__3213E83F2E059C05");
        });

        modelBuilder.Entity<TheTich>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TheTich__3213E83F979C8E25");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
