using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly3.Models
{
    public class MembershipType
    {
        // in Entity Framework - every entity must have a key which will be mapped to the primary key of the corresponding table in the database.
        public byte Id { get; set; }
        public short SignUpFee { get; set; }            // used 'short' because we don't need any values more than 32,000
        public byte DurationInMonths { get; set; }      // used 'byte' because the largest number we want to store is 12 for 12 months
        public byte DiscountRate { get; set; }          // used 'byte' because this number is goint to be a percentage between 0 and 100
    }
}


