using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly3.Models
{
    public class Customer
    {
        // properties of the Customer class
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; }
        public MembershipTypes3 MembershipTypes3 { get; set; }
        public byte MembershipTypeId { get; set; }
        public byte MembershipTypesId3 { get; set; }
    }
}

