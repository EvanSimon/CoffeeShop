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

        [Required]
        [RegularExpression(@"^(((0?[1-9]|1[012])/(0?[1-9]|1\d|2[0-8])|(0?[13456789]|1[012])/(29|30)|(0?[13578]|1[02])/31)/(19|[2-9]\d)\d{2}|0?2/29/((19|[2-9]\d)(0[48]|[2468][048]|[13579][26])|(([2468][048]|[3579][26])00)))$")]
        public string Birthday { set; get; }

        public UserInfo()
        {
            FirstName = "";
            LastName = "";
            Email = "";
            Password = "";
            PhoneNumber = "";
            Birthday = "";
        }
        public UserInfo(string fn, string ln)
        {
            FirstName = fn;
            LastName = ln;

        }
       

    }
}