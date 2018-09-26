using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        // 1.) Computes Full Name.
        // 2.) Computes Height in CM.
        // 3.) Computes if user can vote.

        static void Main(string[] args)
        {
            #region Part1
            string firstName;
            string middleName;
            string lastName;

            System.Console.Write("First Name : ");
            firstName = System.Console.ReadLine();

            System.Console.Write("Middle Name : ");
            middleName = System.Console.ReadLine();

            System.Console.Write("Last Name : ");
            lastName = System.Console.ReadLine();

            string fullName = firstName + " " + middleName + ". " + lastName;

            System.Console.WriteLine(fullName);

            System.Threading.Thread.Sleep(5000);
            #endregion

            #region Part 2
            const double multiplier = 2.54;
            const int inchesInFoot = 12;

            System.Console.Write("Height In Feet : ");
            int heightInFeet = int.Parse(System.Console.ReadLine());

            System.Console.Write("Extra Inches : ");
            double heightInInches = double.Parse(System.Console.ReadLine());

            double inches = inchesInFoot * heightInFeet;
            inches += heightInInches;


            double centimeters = inches * multiplier;

            System.Console.WriteLine(centimeters);

            System.Threading.Thread.Sleep(5000);
            #endregion

            #region Part 3
            System.Console.Write("How old are you? : ");
            int age = int.Parse(System.Console.ReadLine());

            System.Console.Write("Are you a citizen of America? : ");
            bool isCitizen = bool.Parse(System.Console.ReadLine());

            bool canVote = age > 17 && isCitizen;

            System.Console.WriteLine(canVote);

            System.Threading.Thread.Sleep(5000);
            #endregion
        }
    }
}
