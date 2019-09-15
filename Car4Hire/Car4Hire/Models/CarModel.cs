namespace Car4Hire.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CarModel : DbContext
    {
        public CarModel()
            : base("name=Model11")
        {
        }

        public virtual DbSet<Car> Cars { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>()
                .Property(e => e.carName)
                .IsFixedLength();

            modelBuilder.Entity<Car>()
                .Property(e => e.carNumber)
                .IsFixedLength();

            modelBuilder.Entity<Car>()
                .Property(e => e.carModel)
                .IsFixedLength();
        }
    }
}
