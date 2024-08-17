using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Cuoiki_1_
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<BaoHanh> BaoHanhs { get; set; }
        public virtual DbSet<GiaoDich> GiaoDiches { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LichSuBaoHanh> LichSuBaoHanhs { get; set; }
        public virtual DbSet<LichSuGiaoDich> LichSuGiaoDiches { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Xe> Xes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.GiaoDiches)
                .WithOptional(e => e.KhachHang)
                .WillCascadeOnDelete();

            modelBuilder.Entity<User>()
                .HasMany(e => e.LichSuGiaoDiches)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.MaUser)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Xe>()
                .HasMany(e => e.GiaoDiches)
                .WithOptional(e => e.Xe)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Xe>()
                .HasMany(e => e.LichSuGiaoDiches)
                .WithOptional(e => e.Xe)
                .WillCascadeOnDelete();
        }
    }
}
