using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserRegistration userRegistration = new UserRegistration();
            userRegistration.ValidateFirstName("Rohan");
            userRegistration.ValidateLastName("Shewale");
            userRegistration.ValidateEmail("rohanshewale50@gmail.com");
            userRegistration.ValidatePhoneNumber("91 1234567890");
            userRegistration.ValidatePasswordOne("asdf12#4");
            userRegistration.ValidatePasswordTwo("asdF12#f");
            userRegistration.ValidatePasswordThree("asdF12#f");
            Console.ReadKey();
        }
    }
}
