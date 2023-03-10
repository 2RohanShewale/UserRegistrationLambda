using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationEx
{
    internal class UserRegistration
    {
        List<UserRegistrationModel> registrationModels = new List<UserRegistrationModel>();
        public UserRegistration()
        {
            UserRegistrationModel UserClassModel = new UserRegistrationModel();
            registrationModels.Add(UserClassModel);
        }
        public void ValidateFirstName(string firstName)
        {
            if (registrationModels.Any(x=>x.firstName.IsMatch(firstName)))
            {
                Console.WriteLine("It is valid.");
            }
            else
            {
                Console.WriteLine("It is not valid.");
            }
        }
        public void ValidateLastName(string lastName)
        {
            if (registrationModels.Any(x => x.lastName.IsMatch(lastName)))
            {
                Console.WriteLine("It is valid.");
            }
            else
            {
                Console.WriteLine("It is not valid.");
            }
        }
        public void ValidateEmail(string email)
        {
            if (registrationModels.Any(x => x.email.IsMatch(email)))
            {
                Console.WriteLine("It is valid.");
            }
            else
            {
                Console.WriteLine("It is not valid.");
            }
        }
        public void ValidatePhoneNumber(string number)
        {
            if (registrationModels.Any(x => x.phoneNumber.IsMatch(number)))
            {
                Console.WriteLine("It is valid.");
            }
            else
            {
                Console.WriteLine("It is not valid.");
            }
        }
        public void ValidatePasswordOne(string password)
        {
            if (registrationModels.Any(x => x.PasswordRuleOne.IsMatch(password)))
            {
                Console.WriteLine("It is valid.");
            }
            else
            {
                Console.WriteLine("It is not valid.");
            }
        }
    }
}
