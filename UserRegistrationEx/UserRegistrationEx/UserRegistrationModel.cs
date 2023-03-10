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
    }
}
