namespace Car4Hire.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.ComponentModel;

    [Table("Car")]
    public partial class Car
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Range(10000,999999999 ,ErrorMessage ="Enter values in the range 10000 to 999999999")]
        public int Id { get; set; }

        [Required]
        [StringLength(15)]
        [DisplayName("Car Name")]

        public string carName { get; set; }

        [Required]
        [StringLength(7)]
        [DisplayName("Car Number")]
        [RegularExpression(@"A -Za-z]\w{1,7}", ErrorMessage = "Should Start with a character")]
        public string carNumber { get; set; }

        [StringLength(10)]
        [DisplayName("Car Model")]
        public string carModel { get; set; }

        [Column(TypeName = "date")]
        [DisplayName("Registration Date")]
        public DateTime registrationDate { get; set; }
    }
}
