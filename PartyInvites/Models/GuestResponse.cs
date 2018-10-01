using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage ="Please input your name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please input your email address")]
        [RegularExpression(".+\\@.+\\..+",ErrorMessage ="Please input a valid email adress")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Please input your phone")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please specify whether you'll attend")]
        public bool? WillAttend { get; set; }
    }
}
