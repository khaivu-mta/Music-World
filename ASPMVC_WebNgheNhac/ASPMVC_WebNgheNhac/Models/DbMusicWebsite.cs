namespace ASPMVC_WebNgheNhac.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DbMusicWebsite : DbContext
    {
        public DbMusicWebsite()
            : base("name=DbMusicWebsite")
        {
        }

        public virtual DbSet<BANNHAC> BANNHACs { get; set; }
        public virtual DbSet<DANHSACHNHAC> DANHSACHNHACs { get; set; }
        public virtual DbSet<NGUOIDUNG> NGUOIDUNGs { get; set; }
        public virtual DbSet<QUYENTRUYCAP> QUYENTRUYCAPs { get; set; }
        public virtual DbSet<THELOAI> THELOAIs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BANNHAC>()
                .HasMany(e => e.DANHSACHNHACs)
                .WithMany(e => e.BANNHACs)
                .Map(m => m.ToTable("DANHSACHNHAC_BANNHAC").MapLeftKey("MaBanNhac").MapRightKey("MaDanhSach"));

            modelBuilder.Entity<BANNHAC>()
                .HasMany(e => e.THELOAIs)
                .WithMany(e => e.BANNHACs)
                .Map(m => m.ToTable("THELOAI_BANNHAC").MapLeftKey("MaBanNhac").MapRightKey("MaTheLoai"));

            modelBuilder.Entity<NGUOIDUNG>()
                .HasMany(e => e.DANHSACHNHACs)
                .WithMany(e => e.NGUOIDUNGs)
                .Map(m => m.ToTable("NGUOIDUNG_DANHSACHNHAC").MapLeftKey("Email").MapRightKey("MaDanhSach"));
        }
    }
}
