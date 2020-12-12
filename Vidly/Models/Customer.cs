using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        public MembershipType membershipType { get; set; }
      
        [Display(Name = "Membership")]
        public byte MembershipTypeId { get; set; }

        [Display(Name="Date Of Birth")]
        public DateTime? Dob { get; set; }
    }
}