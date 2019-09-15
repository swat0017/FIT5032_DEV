namespace Car4Hire.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string UserId { get; set; }

        [Required]
        [StringLength(10)]
        public string Name { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PhoneNumber { get; set; }

        [StringLength(10)]
        public string City { get; set; }

        [StringLength(10)]
        public string occupation { get; set; }

        [StringLength(10)]
        public string zipCode { get; set; }

        [StringLength(10)]
        public string suburb { get; set; }
    }
}
