using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly3.Models
{
    public class MembershipType
    {
        // in Entity Framework - every entity must have a key which 
        // will be mapped to the primary key of the corresponding table in the database.
        public byte Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public short SignUpFee { get; set; }      
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
    }
}


