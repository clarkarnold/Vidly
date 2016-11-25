using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }

        // These just make the code more readable and maintainable..
        // Ie: Unknown and Payasyougo can be accessed by accessing static
        // MembershipType.Unknown ... Will return 0, and 
        // MembershipType.PayAsYouGo will return 1.

        public static readonly byte Unknown = 0;
        public static readonly byte PayAsYouGo = 1;

    }
}