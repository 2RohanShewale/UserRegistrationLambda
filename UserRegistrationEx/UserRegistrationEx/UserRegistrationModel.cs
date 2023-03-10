using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationEx
{
    public class UserRegistrationModel
    {
        public Regex firstName = new Regex(@"^[A-Z][a-z]{3,}?");
        public Regex lastName = new Regex(@"^[A-Z][a-z]{3,}?");
        public Regex email = new Regex(@"^[a-zA-Z]{3,}[.+-_]{0,1}[0-9]{0,}[@][a-zA-Z]+[.][a-z]{2,3}([.][a-z]{2}){0,1}$");
        public Regex phoneNumber = new Regex(@"^[0-9]{1,2}\s[0-9]{10}$");
        public Regex PasswordRuleOne = new Regex(@".{8,}$");
        public Regex PasswordRuleTwo = new Regex(@"^(?=.*[A-Z]).{8,}$");
        public Regex PasswordRuleThree = new Regex(@"^(?=.*[0-9])(?=.*[A-Z]).{8,}$");
        public Regex PasswordRuleFour = new Regex(@"^(?=.*[!@#$%^&*()-+])(?=.*[0-9])(?=.*[A-Z]).{8,}$");
    }
}
