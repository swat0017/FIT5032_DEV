namespace Car4Hire.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CustomerModel : DbContext
    {
        public CustomerModel()
            : base("name=CustomerModel")
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(e => e.UserId)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .Property(e => e.PhoneNumber)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Customer>()
                .Property(e => e.City)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .Property(e => e.occupation)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .Property(e => e.zipCode)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .Property(e => e.suburb)
                .IsFixedLength();
        }
    }
}
