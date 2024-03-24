using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Wpf_Login.Models
{
    public partial class Context : DbContext
    {
        public Context()
            : base("name=Context")
        {
        }

        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<匯款資訊> 匯款資訊 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<匯款資訊>()
                .Property(e => e.顧客)
                .IsFixedLength();

            modelBuilder.Entity<匯款資訊>()
                .Property(e => e.金額)
                .HasPrecision(18, 0);

            modelBuilder.Entity<匯款資訊>()
                .Property(e => e.幣別)
                .IsFixedLength();

            modelBuilder.Entity<匯款資訊>()
                .Property(e => e.匯款類別)
                .IsFixedLength();

            modelBuilder.Entity<匯款資訊>()
                .Property(e => e.匯款性質)
                .IsFixedLength();

            modelBuilder.Entity<匯款資訊>()
                .Property(e => e.匯款人)
                .IsFixedLength();

            modelBuilder.Entity<匯款資訊>()
                .Property(e => e.附言)
                .IsFixedLength();

            modelBuilder.Entity<匯款資訊>()
                .Property(e => e.原始金額)
                .IsFixedLength();

            modelBuilder.Entity<匯款資訊>()
                .Property(e => e.匯率)
                .IsFixedLength();

            modelBuilder.Entity<匯款資訊>()
                .Property(e => e.是否轉接)
                .IsFixedLength();
        }
    }
}
