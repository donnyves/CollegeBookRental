using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CollegeBookRental.Models
{
    public class MembershipType
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public byte SignUpFee { get; set; }

        [Required]
        public Byte ChargeRateMonthly { get; set; }

        [Required]
        [DisplayName("Rental Rate")]
        public Byte ChargeRateSemiAnnual { get; set; }

    }
}