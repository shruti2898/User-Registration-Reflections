using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationReflections
{
    class User
    {
        string Regex_Name = "^[A-Z][a-z]{2,}$";

        string Regex_MobileNumber = "^([0-9]{2}[ ])?[6-9][0-9]{9}$";

        string Regex_Password = @"^(?=.{8,}$)(?=.*?[0-9])(?=.*[A-Z])[a-zA-Z0-9]*[#!@$^&-][a-zA-Z0-9]*$";

        string Regex_Email = "^[a-z][a-z0-9]{2,}([-.+]{1}[a-z0-9]{3})?[@][a-z0-9]{1,}[.][a-z]{3}([.][a-z]{2,3})?$";

        public bool isValidName(string name)
        {
            return Regex.IsMatch(name, Regex_Name);
        }
       
        public bool isValidMobileNumber(string mobile)
        {
            return Regex.IsMatch(mobile, Regex_MobileNumber);
        }
        
        public bool isValidPassword(string passsword)
        {
            return Regex.IsMatch(passsword, Regex_Password);
        }
        public bool isValidEmail(string email)
        {
            return Regex.IsMatch(email, Regex_Email);
        }
    }
}
