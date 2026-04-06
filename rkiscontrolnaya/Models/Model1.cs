namespace ikrgbl.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Goods> Goods { get; set; }
        public virtual DbSet<Sold_item> Sold_item { get; set; }
        public virtual DbSet<Workers> Workers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Goods>()
                .HasMany(e => e.Sold_item)
                .WithOptional(e => e.Goods)
                .HasForeignKey(e => e.ID_Good);

            modelBuilder.Entity<Workers>()
                .HasMany(e => e.Sold_item)
                .WithOptional(e => e.Workers)
                .HasForeignKey(e => e.ID_Worker);
        }
    }
}
