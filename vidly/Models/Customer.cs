using System;
using System.ComponentModel.DataAnnotations;
namespace Vidly.Models
{
    public class Customer
    {

        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter customer's name")]
        [StringLength(255)]
        public string Name { get; set; }
        [Min18YearsIfMember]
        public DateTime Birthdate { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        [Display(Name = "Membership Type")]
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }
    }
}