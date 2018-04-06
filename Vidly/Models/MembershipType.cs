
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }

        [Display(Name="Membership Type")]
        public string MembershipName { get; set; }

        public short SignUpFee { get; set; }

        public byte DurationInMonths { get; set; }

        public byte DiscountRate { get; set; }

        public static readonly byte Unkown = 0;
        public static readonly byte PayAsYouGo = 1;
    }
}