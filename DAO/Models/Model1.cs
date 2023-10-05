using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DAO.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<CHITIETCOMBO> CHITIETCOMBOes { get; set; }
        public virtual DbSet<CHITIETDONHANG> CHITIETDONHANGs { get; set; }
        public virtual DbSet<CHUCVU> CHUCVUs { get; set; }
        public virtual DbSet<COMBO> COMBOes { get; set; }
        public virtual DbSet<DIEUKIEN> DIEUKIENs { get; set; }
        public virtual DbSet<DONHANG> DONHANGs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<KHUYENMAI> KHUYENMAIs { get; set; }
        public virtual DbSet<LOAISANPHAM> LOAISANPHAMs { get; set; }
        public virtual DbSet<NGUOIDUNG> NGUOIDUNGs { get; set; }
        public virtual DbSet<SANPHAM> SANPHAMs { get; set; }
        public virtual DbSet<SANPHAMHANGNGAY> SANPHAMHANGNGAYs { get; set; }
        public virtual DbSet<THONGBAOHANGNGAY> THONGBAOHANGNGAYs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CHITIETCOMBO>()
                .Property(e => e.MASANPHAM)
                .IsUnicode(false);

            modelBuilder.Entity<CHITIETCOMBO>()
                .Property(e => e.MACOMBO)
                .IsUnicode(false);

            modelBuilder.Entity<CHITIETDONHANG>()
                .Property(e => e.MASANPHAM)
                .IsUnicode(false);

            modelBuilder.Entity<CHITIETDONHANG>()
                .Property(e => e.MADONHANG)
                .IsUnicode(false);

            modelBuilder.Entity<CHUCVU>()
                .Property(e => e.MACHUCVU)
                .IsUnicode(false);

            modelBuilder.Entity<CHUCVU>()
                .HasMany(e => e.NGUOIDUNGs)
                .WithRequired(e => e.CHUCVU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<COMBO>()
                .Property(e => e.MACOMBO)
                .IsUnicode(false);

            modelBuilder.Entity<COMBO>()
                .Property(e => e.ANH)
                .IsUnicode(false);

            modelBuilder.Entity<DIEUKIEN>()
                .Property(e => e.MADIEUKIEN)
                .IsUnicode(false);

            modelBuilder.Entity<DIEUKIEN>()
                .HasMany(e => e.KHUYENMAIs)
                .WithRequired(e => e.DIEUKIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DONHANG>()
                .Property(e => e.MADONHANG)
                .IsUnicode(false);

            modelBuilder.Entity<DONHANG>()
                .Property(e => e.MANGUOIDUNG)
                .IsUnicode(false);

            modelBuilder.Entity<DONHANG>()
                .Property(e => e.MAKHACHHANG)
                .IsUnicode(false);

            modelBuilder.Entity<DONHANG>()
                .Property(e => e.MAKHUYENMAI)
                .IsUnicode(false);

            modelBuilder.Entity<DONHANG>()
                .HasMany(e => e.CHITIETDONHANGs)
                .WithRequired(e => e.DONHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.MAKHACHHANG)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.SODIENTHOAI)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .HasMany(e => e.DONHANGs)
                .WithRequired(e => e.KHACHHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHUYENMAI>()
                .Property(e => e.MAKHUYENMAI)
                .IsUnicode(false);

            modelBuilder.Entity<KHUYENMAI>()
                .Property(e => e.MADIEUKIEN)
                .IsUnicode(false);

            modelBuilder.Entity<KHUYENMAI>()
                .HasMany(e => e.DONHANGs)
                .WithRequired(e => e.KHUYENMAI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOAISANPHAM>()
                .Property(e => e.MALOAISP)
                .IsUnicode(false);

            modelBuilder.Entity<LOAISANPHAM>()
                .HasMany(e => e.SANPHAMs)
                .WithRequired(e => e.LOAISANPHAM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NGUOIDUNG>()
                .Property(e => e.MANGUOIDUNG)
                .IsUnicode(false);

            modelBuilder.Entity<NGUOIDUNG>()
                .Property(e => e.TENDANGNHAP)
                .IsUnicode(false);

            modelBuilder.Entity<NGUOIDUNG>()
                .Property(e => e.MATKHAU)
                .IsUnicode(false);

            modelBuilder.Entity<NGUOIDUNG>()
                .Property(e => e.MACHUCVU)
                .IsUnicode(false);

            modelBuilder.Entity<NGUOIDUNG>()
                .HasMany(e => e.DONHANGs)
                .WithRequired(e => e.NGUOIDUNG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NGUOIDUNG>()
                .HasMany(e => e.THONGBAOHANGNGAYs)
                .WithRequired(e => e.NGUOIDUNG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SANPHAM>()
                .Property(e => e.MASANPHAM)
                .IsUnicode(false);

            modelBuilder.Entity<SANPHAM>()
                .Property(e => e.MALOAISP)
                .IsUnicode(false);

            modelBuilder.Entity<SANPHAM>()
                .Property(e => e.ANHSANPHAM)
                .IsUnicode(false);

            modelBuilder.Entity<SANPHAM>()
                .HasMany(e => e.CHITIETDONHANGs)
                .WithRequired(e => e.SANPHAM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SANPHAM>()
                .HasOptional(e => e.SANPHAMHANGNGAY)
                .WithRequired(e => e.SANPHAM);

            modelBuilder.Entity<SANPHAMHANGNGAY>()
                .Property(e => e.MASANPHAM)
                .IsUnicode(false);

            modelBuilder.Entity<THONGBAOHANGNGAY>()
                .Property(e => e.MATHONGBAO)
                .IsUnicode(false);

            modelBuilder.Entity<THONGBAOHANGNGAY>()
                .Property(e => e.MANGUOIDUNG)
                .IsUnicode(false);
        }
    }
}
