using System;

namespace UserRegistrationReflections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====================================================User Registration===============================================");
            Console.Write("\nPlease enter user details\n");

            Console.Write("First Name:     ");
            string firstName = Console.ReadLine();

            Console.Write("Last Name:     ");
            string lastName = Console.ReadLine();

            Console.Write("Email:     ");
            string email = Console.ReadLine();

            Console.Write("Mobile Number:     ");
            string mobile = Console.ReadLine();

            Console.Write("Password:     ");
            string password = Console.ReadLine();


            User user = new User();

            Console.WriteLine("\n{0}\n{1}\n{2}\n{3}\n{4} ",
                         (user.isValidName(firstName)) ? "First name is valid" : "First name is invalid",
                         (user.isValidName(lastName)) ? "Last name is valid" : "Last name is invalid",
                         (user.isValidEmail(email)) ? "Email address is valid" : "Email address is invalid",
                         (user.isValidMobileNumber(mobile)) ? "Mobile number is valid" : "Mobile number is invalid",
                         (user.isValidPassword(password)) ? "Password is valid" : "Password is invalid\n\n\n");


            UserReflection.UserRegistrationReflectionTest();
        }
    }
        
}
