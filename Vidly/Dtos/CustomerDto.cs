﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedtoNewsletter { get; set; }

        public MembershipTypeDto MembershipType { get; set; }

        public byte MembershipTypeId { get; set; }

       // [Min18YearIfAMember]
        public DateTime? Birthdate { get; set; }

    }
}