using System;
using System.Collections.Generic;

namespace MethodsExercise3
{
    class Program
    {
        // Main method: Entry point of the program.
        static void Main(string[] args)
        {
            // Calling PrintThousand method to print numbers from 1000 to -1000.
            PrintThousand();

            // Calling IncreByThree method to print numbers from 3 to 999, incrementing by 3.
            IncreByThree();
        }

        // 1) Method to print numbers from 1000 down to -1000.
        public static void PrintThousand()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        // 2) Method to print numbers from 3 to 999, incrementing by 3 each time.
        public static void IncreByThree()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        // 3) Method to check equality of two integers.
        public static void Equality()
        {
            int a = 5;
            int b = 5;
            if (a == b)
            {
                Console.WriteLine("they're equal eachother");
            }
            else
            {
                Console.WriteLine("They're not equal");
            }
        }

        //4) Determine if a number is even or odd.
        public static void EvenOdd(int eo)
        {
            if (eo % 2 == 0)
            {
                Console.WriteLine("it is even");
            }
            else
            {
                Console.WriteLine("it is odd");
            }
        }

        //5) Check if a number is positive or negative.
        public static void PosOrNeg(int number)
        {
            if (number > 0)
            {
                Console.WriteLine("it is positive");
            }
            else
            {
                Console.WriteLine("it is negative");
            }
        }

        //6) Determine voting eligibility based on age.
        public static void VotingAge (int age)
        {
            if (age >= 18)
            {
                Console.WriteLine("You can vote!");
            }
            else
            {
                Console.WriteLine("Sorry bud, you're not old enough yet");
            }
        }


        //7) Check if an integer is within the range -10 to 10.
        public static bool Range(int num)
        {
            if (num <= 10 && num >= -10)
            {
                return true;

            }
            else
            {
                return false;
            }
        }

        //8) Display the multiplication table (1 to 12) of a given integer.
        public static void Table()
        {
            Console.Write("Enter an integer: ");
            int number = int.Parse(Console.ReadLine());

            // Display the multiplication table for the given integer
            Console.WriteLine($"\nMultiplication Table for {number}:");

            for (int i = 1; i <= 12; i++)
            {
                int result = number * i;
                Console.WriteLine($"{number} x {i} = {result}");
            }
        }
    }

        
    }

