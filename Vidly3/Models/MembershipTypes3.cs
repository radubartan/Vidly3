﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly3.Models
{
    public class MembershipTypes3
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }      
    }
}