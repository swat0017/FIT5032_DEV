namespace FIT5032_Wk07.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=FIT5032_Models")
        {
        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Unit> Units { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .Property(e => e.FirstName)
                .IsFixedLength();

            modelBuilder.Entity<Student>()
                .Property(e => e.LastName)
                .IsFixedLength();

            modelBuilder.Entity<Student>()
                .Property(e => e.userId)
                .IsFixedLength();

            modelBuilder.Entity<Student>()
                .HasMany(e => e.Units)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Unit>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Unit>()
                .Property(e => e.Description)
                .IsFixedLength();
        }
    }
}
