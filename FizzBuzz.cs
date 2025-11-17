using System.Collections.Concurrent;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace Fizz_Buzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The variable tracks whether the input is valid.
            bool valid = false;

            // The number is stored here if the input is correct.
            int number = 0;


            // The loop repeats until you enter a valid integer.
            while (!valid)
            {
                string input = Console.ReadLine();

                // We test if the input can be converted to an integer.
                if (int.TryParse(input, out number))
                {
                    // Valid input 
                    valid = true; // The input is valid - we exit the loop.
                }
                else
                {
                    Console.WriteLine("Invalid input, please use only integer");
                }
            }

            // Main FizzBuzz cycle from 1 to the specified number.
            for (int i = 1; i <= number; i++)
            {
                // If divisible by 3 and 5 = FizzBuzz.
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }

                // Pokud dělitelné jen 3 = Fizz.
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }

                // If divisible by only 5 - Buzz.
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }

                // Otherwise, write down the number.
                else
                {
                    Console.WriteLine(i);
                }

            }
            
            
        }
    }
}
