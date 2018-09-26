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

            string firstName;
            string middleName;
            string lastName;

            System.Console.Write("First Name : ");
            firstName = System.Console.ReadLine();

            System.Console.Write("Middle Name : ");
            middleName = System.Console.ReadLine();

            System.Console.Write("Last Name : ");
            lastName = System.Console.ReadLine();

            string fullName = firstName + " " middleName + ". " lastName;

            System.Console.WriteLine(fullName);

            System.Threading.Thread.Sleep(5000);
        }
    }
}
