using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Apps___1_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;  // CREATING THE VARIABLES FOR THE QUESTIONS
            int c = 4;

            // PROBLEM #1
                Console.WriteLine("Console Problem 1:");
                Console.WriteLine("-----------------");
                int problemOne = (a * b) + c; // EQUATION
                Console.WriteLine(problemOne); // PRINTING THE EQUATION
                Console.WriteLine("-----------------");
                Console.WriteLine("Press ENTER to continue...");
                Console.ReadLine();

            // PROBLEM #2
                Console.WriteLine("Console Problem 2:");
                Console.WriteLine("-----------------");
                int problemTwo = a * (b + c); // EQUATION
                Console.WriteLine(problemTwo); // PRINTING THE EQUATION
                Console.WriteLine("-----------------");
                Console.WriteLine("Press ENTER to continue...");
                Console.ReadLine();

            // PROBLEM #3
                Console.WriteLine("Console Problem 3:");
                Console.WriteLine("-----------------");
                int problemThree = (1 + b) * c; // EQUATION
                Console.WriteLine(problemThree); // PRINTING THE EQUATION
                Console.WriteLine("-----------------");
                Console.WriteLine("Press ENTER to continue...");
                Console.ReadLine();

            // PROBLEM #4
                Console.WriteLine("Console Problem 4:");
                Console.WriteLine("-----------------");
                int problemFour = a ^ c; // EQUATION, but instead of "**" to make "a" to the "c" power. You use "^".
                Console.WriteLine(problemFour); // PRINTING THE EQUATION
                Console.WriteLine("-----------------");
                Console.WriteLine("Press ENTER to continue...");
                Console.ReadLine();

            // PROBLEM #5
                Console.WriteLine("Console Problem 5:");
                Console.WriteLine("-----------------");
                int problemFive = b ^ (c - a); // EQUATION, but instead of "**" to make "a" to the "c" power. You use "^".
                Console.WriteLine(problemFive); // PRINTING THE EQUATION
                Console.WriteLine("-----------------");
                Console.WriteLine("Press ENTER to continue...");
                Console.ReadLine();

            // PROBLEM #6
                Console.WriteLine("Console Problem 6:");
                Console.WriteLine("-----------------");
                int problemSix = (c = a) ^ b; // EQUATION, but instead of "**" to make "a" to the "c" power. You use "^".
                Console.WriteLine(problemSix); // PRINTING THE EQUATION
                Console.WriteLine("-----------------");
                Console.WriteLine("Press ENTER to continue...");
                Console.ReadLine();

            // PROBLEM 7
                Console.WriteLine("Console Problem 7:");
                Console.WriteLine("-----------------");
                double problemSeven = 7.8 * a + 5; // EQUATION
                Console.WriteLine(problemSeven); // PRINTING THE EQUATION
                Console.WriteLine("-----------------");
                Console.WriteLine("END OF ASSIGNMENT");
                Console.ReadLine();
        }
    }
}
