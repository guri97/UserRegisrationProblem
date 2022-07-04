﻿namespace UserRegistrationTestAndRegex
{
    public class Program
    {
        static void Main(string[] args)
        {
            char ch;
            do
            {
                Console.WriteLine("Welcome To N unit testing and Exception handling For User Registration Problem");
                Console.Write("\nPlease enter user details\n");
                UserRegistrationDetails user = new UserRegistrationDetails();
                menu(user);
                Console.Write("\nDo you want to continue?(y/n)    ");
                ch = Convert.ToChar(Console.ReadLine());
                Console.Clear();
            } while (ch == 'y');

            Console.ReadKey();
        }

        private static void menu(UserRegistrationDetails user)
        {

            Console.Write("\nFirst Name:     ");
            string firstName = Console.ReadLine();
            Console.Write("\n=====Result======\n");
            bool checkFirstName = user.ValidateFirstName(firstName);
            Console.WriteLine("\n{0}\n{1}\n{2}\n{3}\n{4} ",
            (checkFirstName) ? "First name is valid" : "First name is invalid");
        }
    }
}