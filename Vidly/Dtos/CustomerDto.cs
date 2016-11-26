using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        //[Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }

        // the ? after DateTime makes it nullable, since DateTime is not nullable without this.
        //[Display(Name = "Date of Birth")]
        [Min18YearsIfAMember] // get custom validation from another class we created
        public DateTime? Birthdate { get; set; }
    }
}