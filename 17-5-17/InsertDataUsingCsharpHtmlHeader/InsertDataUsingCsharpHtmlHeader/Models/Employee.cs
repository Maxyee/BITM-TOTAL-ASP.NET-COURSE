using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InsertDataUsingCsharpHtmlHeader.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "Please Provide your Name")]
        [StringLength(20,MinimumLength = 3)]
        public string Name { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Please Provide a valid email")]
        [RegularExpression(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?",ErrorMessage = "Please provide your valid email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please select Your Gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Please Select Your Department Name")]
        public string Department { get; set; }
        public string Address { get; set; }

        public string Password { get; set; }
    }
}