using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CoffeeShopApp.Models
{
    public class UserInfo
    {
        [Required] // attributes 
        [RegularExpression(@"^[a-zA-Z]{2,}$")]
        public string FirstName { set; get; }

        [Required]
        [RegularExpression(@"^[a-zA-Z]{2,}$")]
        public string LastName { set; get; }

        [Required]
        [RegularExpression(@"^[A-z0-9]{5,30}@[a-z]{5,10}.[a-z]{2,3}$")]
        public string Email { set; get; }

        [Required]
        [RegularExpression(@"^[a-zA-Z]{2,}$")]
        public string Password { set; get; }

        [Required]
        [RegularExpression(@"^\d{10}")]
        public string PhoneNumber { set; get; }

        public UserInfo()
        {
            FirstName = "";
            LastName = "";
            Email = "";
            Password = "";
            PhoneNumber = "";
        }
        public UserInfo(string fn, string ln)
        {
            FirstName = fn;
            LastName = ln;

        }
       
    }
}