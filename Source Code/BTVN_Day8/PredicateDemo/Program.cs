using System;
using System.Linq;

namespace PredicateDemo
{
    class Program
    {
        static string ReverseString(string str)
        {
            return new string(str.Reverse().ToArray());
        }
        static void Main(string[] args)
        {
            Predicate<int> isOddDigit = (number) => { return (number % 2 == 1); };
            int number = Convert.ToInt32(Console.ReadLine());
            if (isOddDigit(number))
            {
                Console.WriteLine($"{number} is a Odd Digit");
            }
            else
            {
                Console.WriteLine($"{number} is not a Odd Digit");
            }

            Predicate<string> checkLengthString = (str) => { return (str.Length < 10); };
            if (checkLengthString("abc"))
            {
                Console.WriteLine("Length of string < 10!");
            }
            else
            {
                Console.WriteLine("Length of string >= 10!");
            }

        }
    }
}
